using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEItemLocator
{
    public partial class EEItemLocator : Form
    {
        FileData fileData = new FileData();
        List<string> EnvList = new List<string>();
        readonly LineData lineData = new LineData();
        
        public EEItemLocator()
        {
            string[] arrData;

            InitializeComponent();
            string fileloc = @"XMCItemDetector.txt";

            IEnumerable<string> lines = System.IO.File.ReadLines(fileloc);
            fileData.Lines = lines;

            lineData.EnvironmentList = new List<string>();
            lineData.EnvironmentUrl = new List<string>();
            lineData.EnvironmentScApiKey = new List<string>();
            lineData.EnvironmentEdgeApiKey = new List<string>();

            foreach (string line in lines)
            {
                if (line.StartsWith("Environment")) continue;

                arrData=line.Split(' ');
                
                lineData.EnvironmentList.Add(arrData[0]);                
                lineData.EnvironmentUrl.Add(arrData[1]);                
                lineData.EnvironmentScApiKey.Add(arrData[2]);                
                lineData.EnvironmentEdgeApiKey.Add(arrData[4]);
            }

            EnvironmentList.Items.Clear();
            EnvironmentList.Items.AddRange(lineData.EnvironmentList.ToArray());
            EnvironmentList.SelectedIndex = 0;
        }

        private async Task<GraphQLResponse<Data>> InvokeGraphQLQueryforEdge()
        {
            var graphQLClient = new GraphQLHttpClient("https://edge.sitecorecloud.io/api/graphql/v1", new NewtonsoftJsonSerializer());

            var itemRequest = new GraphQLRequest
            {
                Query = @"query GetItem($id:String, $language: String!) {
               
                    GetItem: item(path: $id, language:$language){
                    id,
                    name
                  }
             
                }",
                OperationName = "GetItem",
                Variables = new
                {
                    id= Path.Text,
                    language= Language.Text,
                    sc_apikey= lineData.EnvironmentEdgeApiKey[EnvironmentList.SelectedIndex]
                }
                
            };

            graphQLClient.HttpClient.DefaultRequestHeaders
                .TryAddWithoutValidation("sc_apikey", lineData.EnvironmentEdgeApiKey[EnvironmentList.SelectedIndex]);

            var graphQLResponse = await graphQLClient.SendQueryAsync<Data>(itemRequest);
            var id = graphQLResponse.Data.GetItem?.Id;

            return graphQLResponse;
        }

        private async Task<GraphQLResponse<Data>> InvokeGraphQLQueryforPreview()
        {
            var envUrl = $"{lineData.EnvironmentUrl[EnvironmentList.SelectedIndex]}?sc_apikey={lineData.EnvironmentScApiKey[EnvironmentList.SelectedIndex]}";

            var graphQLClient = new GraphQLHttpClient(envUrl, new NewtonsoftJsonSerializer());

            var itemRequest = new GraphQLRequest
            {
                Query = @"query GetItem($id:String, $language: String!) {
               
                    GetItem: item(path: $id, language:$language){
                    id,
                    name
                  }
             
                }",
                OperationName = "GetItem",
                Variables = new
                {
                    id = Path.Text,
                    language = Language.Text
                }

            };

            graphQLClient.HttpClient.DefaultRequestHeaders
                .TryAddWithoutValidation("sc_apikey", lineData.EnvironmentScApiKey[EnvironmentList.SelectedIndex]);

            var graphQLResponse = await graphQLClient.SendQueryAsync<Data>(itemRequest);
            var id = graphQLResponse.Data.GetItem?.Id;

            return graphQLResponse;
        }

        private async void Find_Click(object sender, EventArgs e)
        {

            GraphQLResponse<Data> presult = await InvokeGraphQLQueryforPreview();
            if (presult == null)
            {
                Preview.BackColor = Color.Red;
                return;
            }


            if (!string.IsNullOrWhiteSpace(presult.Data?.GetItem?.Id))
            {
                Preview.BackColor = Color.Green;
            }
            else
            {
                Preview.BackColor = Color.Red;
            }

            GraphQLResponse<Data> eresult = await InvokeGraphQLQueryforEdge();
            if (eresult == null)
            {
                ExperienceEdge.BackColor = Color.Red;
                return;
            }


            if (!string.IsNullOrWhiteSpace(eresult.Data?.GetItem?.Id))
            {
                ExperienceEdge.BackColor = Color.Green;
            }
            else
            {
                ExperienceEdge.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preview.BackColor = Color.White;
            ExperienceEdge.BackColor = Color.White;
        }
    }

    public class Data
    {
        public GetItem GetItem { get; set; }
    }

    public class GetItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class LineData
    {
        public List<string> EnvironmentList { get; set; }
        public List<string> EnvironmentUrl { get; set; }
        public List<string> EnvironmentScApiKey { get; set; }
        public List<string> EnvironmentEdgeApiKey { get; set; }
    }

    public class FileData
    {
       public IEnumerable<string> Lines { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
    }
}
