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
        public Note AddNote([FromBody] NoteViewModel noteViewModel)
        {
            var note = _mapper.Map<Note>(noteViewModel);
            _context.Notes.Add(note);
            _context.SaveChanges();
            return note;
        }

        [HttpGet("/notes")]
        public IEnumerable<Note> GetAllNotes()
        {
            return _context.Notes;
        }

        [HttpGet("test")]
        public string Test()
        {
            return "hello";
        }
    }
}
