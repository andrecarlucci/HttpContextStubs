using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HttpContextSubs
{
    public class HttpResponseSub : HttpResponse {
        public override HttpContext HttpContext { get; }
        public override int StatusCode { get; set; }
        public override IHeaderDictionary Headers { get; } = new HeaderDictionarySub();
        public override Stream Body { get; set; }
        public override long? ContentLength { get; set; }
        public override string ContentType { get; set; }
        public override IResponseCookies Cookies { get; }
        public override bool HasStarted { get; }

        public override void OnCompleted(Func<object, Task> callback, object state) {
        }

        public override void OnStarting(Func<object, Task> callback, object state) {
        }

        public override void Redirect(string location, bool permanent) {
        }

        public HttpResponseSub(HttpContext httpContext) {
            HttpContext = httpContext;
        }
    }
}