using NorthWindWebAPI.Business.Entities;
using NorthWindWebAPI.Business.Providers;
using NorthWindWebAPI.Tools.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace NorthWindWebAPI.Tools.Attributes
{
    public class NorthWindBasicAuthenticationAttribute:AuthorizationFilterAttribute
    {
        string[] Roles;
        public NorthWindBasicAuthenticationAttribute(params string[] Role)
        {

            Roles = Role;
        }
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            HttpRequestMessage request = actionContext.Request;
            AuthenticationHeaderValue Authorization = request.Headers.Authorization;
            if(Authorization==null)
            {
                actionContext.Response = new AutehnticationFailureResult("Missing Credentials", request).ExecuteResult();
                return;
            }

            if (Authorization.Scheme != "Basic")
            {
                actionContext.Response = new AutehnticationFailureResult("Missing Schema" , request).ExecuteResult();
                return;
            }


            if( string.IsNullOrEmpty(Authorization.Parameter))
            {
                actionContext.Response = new AutehnticationFailureResult("Missing Credentials", request).ExecuteResult();
            }

            Tuple<string, string> usrNameAndPwd = ExtractUserAndPassword(Authorization.Parameter);

            if(usrNameAndPwd==null)
            {
                actionContext.Response = new AutehnticationFailureResult("Invalid Credentials", request).ExecuteResult();
            }

            using (var model = new NorhWindModel())
            {
                var user = UserProvider.IsAuthenticated(model, usrNameAndPwd.Item1,usrNameAndPwd.Item2);
                if(!user)
                {
                    actionContext.Response = new AutehnticationFailureResult("User Id or Password  Invalid", request).ExecuteResult();
                }
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(usrNameAndPwd.Item1), null);

            }

                //if (actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
                //{
                //    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.NotFound);
                //    actionContext.Response.Content = new StringContent("<p>Use HTTPS instead of HTTP.");
                //    UriBuilder uribuilder = new UriBuilder(actionContext.Request.RequestUri);
                //    uribuilder.Scheme = Uri.UriSchemeHttps;
                //    uribuilder.Port = 44306;

                //    actionContext.Response.Headers.Location = uribuilder.Uri;
                //}
                //else
                //{
                //    base.OnAuthorization(actionContext);
                //}
               
        }

        private Tuple<string, string> ExtractUserAndPassword(string parameter)
        {

            var  decodedUesrDetails=Encoding.UTF8.GetString(Convert.FromBase64String(parameter));

            if(decodedUesrDetails.IndexOf(':')==-1)
            {
                return null;
            }

            var UserNamePwd = decodedUesrDetails.Split(':');

            return new Tuple<string, string>(UserNamePwd[0], UserNamePwd[1]);
        }
    }
}