using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogBackEnd.Classes;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : Controller
    {
        [HttpGet]
        public string Get()
        {
            var newEntry = new Entry(1, "toast", "Banana");

            return newEntry.ToString();
        }
    }
}
