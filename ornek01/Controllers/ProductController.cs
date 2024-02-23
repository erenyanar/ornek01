using Microsoft.AspNetCore.Mvc;

namespace ornek01.Controllers
{

   

    public class ProductController : Controller
    {
        public ContentResult GetProducts()
        {

      ContentResult resuslt = Content("Selam Dünya");
            return resuslt;
        }
      
        
    }
}
