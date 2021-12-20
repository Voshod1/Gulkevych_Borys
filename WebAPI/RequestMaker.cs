using RestSharp;
using System.Collections.Generic;

namespace WebAPI
{
    class RequestMaker
    {
        public IRestResponse upload()
        {
            var client = new RestClient("https://content.dropboxapi.com/2/files/upload");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"Dropbox-API-Arg", "{\"path\": \"/homework/NEWfile.txt\",\"mode\": \"add\",\"autorename\": true,\"mute\": false,\"strict_conflict\": false}" },
                {"Content-Type", "application/octet-stream" },
                {"Authorization", "Bearer Z4Rm6oxQw5oAAAAAAAAAAQLjWTEydjKQb3Sq95MvmvVYtps9ENu3YbSwYhVkJzLK" }
            };
            request.AddHeaders(headers);
            request.AddParameter("application/octet-stream", $@"""src"" : ""IoI.txt""", ParameterType.RequestBody);
            return client.Execute(request);
        }
        public IRestResponse get_file_metadata()
        {

            var client = new RestClient("https://api.dropboxapi.com/2/files/get_metadata");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"Content-Type", "application/json"},
                {"Authorization", "Bearer Z4Rm6oxQw5oAAAAAAAAAAQLjWTEydjKQb3Sq95MvmvVYtps9ENu3YbSwYhVkJzLK" }
            };
            Dictionary<string, string> body = new Dictionary<string, string>()
            {
                {"path", "/homework/Newfile.txt"}
            };
            request.AddHeaders(headers);
            request.AddJsonBody(body);
            return client.Execute(request);
        }
        public IRestResponse delete()
        {
            var client = new RestClient("https://api.dropboxapi.com/2/files/delete_v2");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"Content-Type", "application/json"},
                {"Authorization", "Bearer Z4Rm6oxQw5oAAAAAAAAAAQLjWTEydjKQb3Sq95MvmvVYtps9ENu3YbSwYhVkJzLK" }
            };
            string filePath = "/homework/Newfile.txt";
            Dictionary<string, string> body = new Dictionary<string, string>()
            {
            {"path", filePath}
            };
            request.AddHeaders(headers);
            request.AddJsonBody(body);
            return client.Execute(request);

        }
    }
}
