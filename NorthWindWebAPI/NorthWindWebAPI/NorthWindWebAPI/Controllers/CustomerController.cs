using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NorthWindWebAPI.Services;
using NorthWindWebAPI.Business.Entities;
using NorthWindDataModel;
using NorthWindWebAPI.Tools.Attributes;


namespace NorthWindWebAPI.Controllers
{
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        //[NorthWindBasicAuthentication(Role:"Abc,xyz")]
        
        [Route("CustomerInfo")]        
        public HttpResponseMessage Get()
        {
            var _result = CustomerService.GetCustomer();
            return Request.CreateResponse(HttpStatusCode.Accepted, _result);
        }
        //[NorthWindBasicAuthentication]
        [Route("GetCustormersByParams")]
        [HttpPost]
        public HttpResponseMessage GetCustormersByParams(CustomerFilterVM searchFilter)
        {
            var _result = CustomerService.GetCustomer(searchFilter);
            return Request.CreateResponse(HttpStatusCode.Accepted, _result);          
        }       
    }
}
