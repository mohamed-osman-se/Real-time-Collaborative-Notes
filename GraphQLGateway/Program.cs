
using GraphQLGateway.Mutation;
using GraphQLGateway.Query;
using GraphQLGateway.Subscription;
using GrpcNote.Protos;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
.AddQueryType<Query>()
.AddMutationType<Mutation>()
.AddSubscriptionType<Subscription>()
.AddInMemorySubscriptions();


builder.Services.AddGrpcClient<NoteService.NoteServiceClient>(options =>
{
    options.Address = new Uri(builder.Configuration["grpcuri"]!);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();
app.UseCors("AllowAll");
app.UseWebSockets();

app.MapGraphQL();

app.Run();
