using Tarker.Booking.Api;
using Tarker.Booking.Application;
using Tarker.Booking.Application.DataBase.User.Commands.CreateUser;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

var app = builder.Build();

app.MapPost("/textService", async (ICreateUserCommand service) =>
{

});

//app.MapPost("/createTest", async (IDataBaseService _databaseService) =>
//    {
//        var entity = new Tarker.Booking.Domain.Entities.User.UserEntity
//        {
//            FirstName = "Sebastian",
//            LastName = "Mosquera",
//            UserName = "User01",
//            Password = "sebas123"
//        };
//        await _databaseService.User.AddAsync(entity);
//        await _databaseService.SaveAsync();
//        return "CREATE OK";
//    });
//app.MapGet("/testGet", async (IDataBaseService _databaseService) =>
//{
//    var result = await _databaseService.User.ToListAsync();
//    return result;
//});

app.Run();
