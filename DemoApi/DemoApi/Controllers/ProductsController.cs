using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace DemoApi.Controllers
{
    [RoutePrefix("Accounts")]
    //[RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        // GET: Products/widget/xxx
        [HttpGet, Route("{accountId:validAccount}")]
        public string GetClientAccount(string accountId)
        {
            bool IsValidAccount(string sAccount)
            {
                if (!string.IsNullOrEmpty(sAccount) && sAccount.StartsWith("1234") && sAccount.Length > 5)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("The object is not of type string");
                }
            }

            var result = IsValidAccount(accountId);
            return result.ToString();


        }
    

    // GET: api/Products/5/orders/custid
        //[HttpGet, Route("{id}/orders/{custid:int:range(1-5)}")]
        //public string Get(int id, string custid)
        //{
        //    return "product-orders-" + custid;
        //}

        // POST: api/Products
        //[HttpPost, Route("{id}")]
        //public void Post([FromBody]string value)
        //{
        //}

        //PUT: api/Products/5
        //[HttpPut, Route("{id:int}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //DELETE: api/Products/5
        //[HttpDelete, Route("{id:int}")]
        //public void Delete(int id)
        //{
        //}
    }
}
