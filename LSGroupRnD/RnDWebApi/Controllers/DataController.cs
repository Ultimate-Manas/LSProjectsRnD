using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RnDWebApi.Controllers
{
    public class DataController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Download(string fileName)
        {
            var dataBytes = File.ReadAllBytes(@fileName);
            var dataStream = new MemoryStream(dataBytes);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StreamContent(dataStream);
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = "myFile.txt";
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

            return response;
        }
    }
}
