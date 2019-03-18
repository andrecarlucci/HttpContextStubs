using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Routing;

namespace HttpContextSubs {
    public class ControllerContextSub : ControllerContext {

        public ControllerContextSub() : base(new ActionContext(
                new HttpContextSub(), 
                new RouteData(), 
                new ControllerActionDescriptor()
            )) {
        }
    }
}
