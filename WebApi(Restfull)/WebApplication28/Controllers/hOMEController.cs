using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication28.Models;

namespace WebApplication28.Controllers
{
    public class HomeController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Products()
        {
            return Json(Database.Products);
        }

        [HttpDelete]
        public IHttpActionResult ProductDelete(int id)
        {
            try
            {
                Product _product = Database.Products.Find(x => x.Id == id);
                Database.Products.Remove(_product);
                return Ok(new HttpResponseMessage(HttpStatusCode.OK));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult ProductUpdate(Product product)
        {
            try
            {
                Product _product = Database.Products.Find(x => x.Id == product.Id);
                _product = product;
                return Ok(new HttpResponseMessage(HttpStatusCode.OK));

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
