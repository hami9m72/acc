using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoAnCSharp.GoogleDriveAPI
{
    public static class DriveHelper
    {
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        static private UserCredential credential = ReadCreadential();
        
        public static string GetAccessToken()
        {
            return credential.Token.AccessToken;
        }
        
        // Create Drive API service.
        public static DriveService service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });

        private static UserCredential ReadCreadential()
        {
            UserCredential cre;
            using (var stream =
                new FileStream("./GoogleDriveAPI/credentials.json", FileMode.Open, FileAccess.Read))
            {          
                string credPath = "token.json";
                cre = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
            return cre;
        }

        public static List<Google.Apis.Drive.v3.Data.File> GetFilesInFloder(string floder_id)
        {
            // Define parameters of request.
            string pageToken = null;
            FilesResource.ListRequest listRequest = service.Files.List();
            var driveFiles = new List<Google.Apis.Drive.v3.Data.File>();
            do
            {
                listRequest.Fields = "nextPageToken, files(id,name,size,webContentLink)";
                listRequest.Q = $"parents = '{floder_id}'";
                listRequest.PageToken = pageToken;
                Google.Apis.Drive.v3.Data.FileList reponse = listRequest.Execute();
                foreach (var item in reponse.Files)
                    driveFiles.Add(item);
                pageToken = reponse.NextPageToken;
            } while (!string.IsNullOrEmpty(pageToken));
            return driveFiles;
        }

        

        //public static async Task<HttpResponeMessage> DownloadFile(string fileID,long size)
        //{
        //    var request = service.Files.Get(fileID);
        //    var client = request.Service.HttpClient;

        //    //you would need to know the file size
        //    //var size = await GetFileSize(fileID);


        //    //Stream stream1 = new MemoryStream(1024);
        //    var req = request.CreateRequest();
        //    req.RequestUri = new Uri(req.RequestUri.OriginalString + "?alt=media");
        //    req.Headers.Range = new RangeHeaderValue(0,1024*1024);
        //    var res = await client.SendAsync(req);

        //    return res;

        //    //using (var file = new FileStream("Hello.mp4", FileMode.Create, FileAccess.ReadWrite))
        //    //{
        //    //    if (res.StatusCode == HttpStatusCode.PartialContent || res.IsSuccessStatusCode)
        //    //    {
        //    //        using (var stream = await res.Content.ReadAsStreamAsync())
        //    //        {
        //    //            await stream.CopyToAsync(file);
        //    //        }
        //    //    }
        //    //}
                


        //    //using (var file = new FileStream(downloadFileName, FileMode.CreateNew, FileAccess.ReadWrite))
        //    //{

        //    //    file.SetLength(size);

        //    //    var chunks = (size / ChunkSize) + 1;
        //    //    for (long index = 0; index < chunks; index++)
        //    //    {

        //    //        var request = exportRequest.CreateRequest();

        //    //        var from = index * ChunkSize;
        //    //        var to = from + ChunkSize - 1;

        //    //        request.Headers.Range = new RangeHeaderValue(from, to);

        //    //        var response = await client.SendAsync(request);

        //    //        if (response.StatusCode == HttpStatusCode.PartialContent || response.IsSuccessStatusCode)
        //    //        {
        //    //            using (var stream = await response.Content.ReadAsStreamAsync())
        //    //            {
        //    //                file.Seek(from, SeekOrigin.Begin);
        //    //                await stream.CopyToAsync(file);
        //    //            }
        //    //        }
        //    //    }
        //    //}
        //}
        private static async Task<long> GetFileSize(string fileId)
        {
            var file = await service.Files.Get(fileId).ExecuteAsync();
            return file.Size.HasValue ? file.Size.Value : 0;
        }
    }
}
