using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RnDWebApi.Controllers
{
    [RoutePrefix("Data")]
    public class DataController : ApiController
    {
        [HttpGet]
        [Route("Download")]
        public HttpResponseMessage Download(string filePath)
        {
            var dataBytes = File.ReadAllBytes(filePath);
            var dataStream = new MemoryStream(dataBytes);
            var fileName = Path.GetFileName(filePath);
            var ext = Path.GetExtension(fileName);
            // below code stuff to prepare the response object from endpoint
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StreamContent(dataStream);
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = fileName;
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

            return response;
        }
    }
}
