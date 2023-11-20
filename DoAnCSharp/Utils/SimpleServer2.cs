using DoAnCSharp.GoogleDriveAPI;
using SimpleHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DoAnCSharp.Utils
{
    public class SimpleServer2
    {
        private Thread thread;
        public void CreateServer()
        {
            Route.Add("/music/{id}/{size}", async (req, res, props) =>
            {
                string songId = props["id"];
                long maxSize = long.Parse(props["size"]);
                long chunkSize = 10000000;
                long start=0;
                long end=0;
                if (req.Headers.Get("Range") == null)
                {
                    start = 0;
                }
                else
                {
                    start= long.Parse(Regex.Replace(req.Headers.Get("Range"), "\\D", ""));
                }
                end = Math.Min(start + chunkSize, maxSize - 1);
                long contentLength = end - start + 1;

                var exRequest = DriveHelper.service.Files.Get(songId);
                var client = exRequest.Service.HttpClient;
                var request =exRequest.CreateRequest();
                request.Headers.Range = new RangeHeaderValue(start, end);
                var response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.PartialContent || response.IsSuccessStatusCode)
                {
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        res.Headers.Add("Content-Range", $"bytes {start}-{end}/{maxSize}");
                        res.Headers.Add("Accept-Ranges", $"bytes");
                        res.Headers.Add("Content-Length", $"{contentLength}");
                        res.Headers.Add("Content-Type", $"video/mp4");
                        res = res.WithCode(HttpStatusCode.PartialContent);
                        res.AsStream(req, stream);
                    }
                }
          
            });

            //Route.Add("/users/{id}", (req, res, props) =>
            //{
            //    res.AsText($"You have requested user #{props["id"]}");
            //}, "POST");

            //Route.Add("/header", (req, res, props) =>
            //{
            //    res.AsText($"Value of my-header is: {req.Headers["my-header"]}");
            //});
            thread = new Thread(new ThreadStart(this.Start));
            thread.Start();
            
        }

        private void Start()
        {
            HttpServer.ListenAsync(
                    80,
                    CancellationToken.None,
                    Route.OnHttpRequestAsync
                )
            .Wait();
        }
    }
}

