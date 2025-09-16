using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcNote.Protos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Services.Grpc.Interfaces;
using Services.Grpc.Models;
using SharpCompress.Compressors.PPMd;

namespace Services.Grpc.Repo
{
    public class NoteRepo : INoteRepo
    {
        private readonly IMongoCollection<Note> _notes;
        public NoteRepo(IMongoDatabase database)
        {

            _notes = database.GetCollection<Note>("notes");

        }

        public async Task CreateAsync(Note note)
        {
            await _notes.InsertOneAsync(note);
        }

        public async Task<IEnumerable<NoteDTO>> GetAllAsync()
        {
            var result = await _notes.AsQueryable().Select(n => new NoteDTO
            {
                Title = n.Title,
                Content = n.Content
            }).ToListAsync();
            return result;
        }
    }
}