using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NoteService.Models;
using NoteService.ViewModels;

namespace NoteService.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Note, NoteViewModel>();
            CreateMap<NoteViewModel, Note>();
        }
    }
}
