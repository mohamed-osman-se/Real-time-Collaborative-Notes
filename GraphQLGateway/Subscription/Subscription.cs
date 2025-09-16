using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcNote.Protos;

namespace GraphQLGateway.Subscription
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public NoteDTO OnNoteAdded([EventMessage] NoteDTO note) => note;
    }
}