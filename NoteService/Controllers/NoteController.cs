using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NoteService.Controllers
{
    [Route("api/[controller]")]
    public class NoteController : Controller
    {
        private NoteServiceContext _context;

        public NoteController(NoteServiceContext context)
        {
            _context = context;
        }

        public ActionResult AddNote()
        {
            return Ok();
        }

        [HttpGet("test")]
        public string Test()
        {
            return "hello";
        }
    }
}
