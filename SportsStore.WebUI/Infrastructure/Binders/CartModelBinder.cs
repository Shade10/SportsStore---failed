using System.Web.Mvc;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Binders {
    public class CartModelBinder : IModelBinder {
        private const string sessionKey = "Cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) {
            //Get Cart obiect from session
            Cart cart = null;
            if (controllerContext.HttpContext.Session != null) {
                cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            }

            //created Cart obiect, if not find in session-date 
            if (cart == null) {
                cart = new Cart();
                if (controllerContext.HttpContext.Session != null) {
                    controllerContext.HttpContext.Session[sessionKey] = cart;
                }
            }
            return cart;
        }
    }
}