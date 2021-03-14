using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoteService.ViewModels
{
    public class NoteViewModel
    {
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
