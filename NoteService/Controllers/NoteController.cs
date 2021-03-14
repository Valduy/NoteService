using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NoteService.Models;
using NoteService.ViewModels;

namespace NoteService.Controllers
{
    [Route("api/[controller]")]
    public class NoteController : Controller
    {
        private NoteServiceContext _context;
        private IMapper _mapper;

        public NoteController(
            NoteServiceContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("notes")]
        public ActionResult AddNote([FromBody] NoteViewModel noteViewModel)
        {
            if (ModelState.IsValid)
            {
                var note = _mapper.Map<Note>(noteViewModel);
                _context.Notes.Add(note);
                _context.SaveChanges();
                return Ok(note);
            }

            return BadRequest();
        }

        [HttpGet("notes")]
        public IEnumerable<Note> GetAllNotes()
        {
            return _context.Notes.Select(n => new Note()
            {
                Id = n.Id,
                Title = n.Title ?? n.Content.Substring(0, Math.Min(200, n.Content.Length)),
                Content = n.Content
            });
        }

        [HttpGet("test")]
        public string Test()
        {
            return "hello";
        }
    }
}
