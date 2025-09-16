using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcNote.Protos;
using Services.Grpc.Models;

namespace Services.Grpc.Interfaces
{
    public interface INoteRepo
    {
        Task CreateAsync(Note note);
        Task<IEnumerable<NoteDTO>> GetAllAsync();
    }
}