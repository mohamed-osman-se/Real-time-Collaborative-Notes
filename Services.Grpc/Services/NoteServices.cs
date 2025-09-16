using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcNote.Protos;
using Services.Grpc.Interfaces;
using Services.Grpc.Models;

namespace Services.Grpc.Services
{
    public class NoteServices : NoteService.NoteServiceBase
    {
        private readonly INoteRepo _noteRepo;

        public NoteServices(INoteRepo noteRepo)
        {
            _noteRepo = noteRepo;
        }

        public override async Task<GrpcNote.Protos.Void> CreateNote(NoteDTO request, ServerCallContext context)
        {
            Note note = new Note
            {
                Title = request.Title,
                Content = request.Content
            };
            await _noteRepo.CreateAsync(note);
            return new GrpcNote.Protos.Void();
        }

        public override async Task<NotesDTO> GetAllNotes(GrpcNote.Protos.Void request, ServerCallContext context)
        {
            var notes = await _noteRepo.GetAllAsync();
            var response = new NotesDTO();
            response.NotesDto.AddRange(notes);
            return response;
        }
    }
}