using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ScamDb>(opt => opt.UseInMemoryDatabase("ScamList"));
var app = builder.Build();

// May implement dev/prod envs in the future
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

// Get scam item list
app.MapGet("/scamitems", async (ScamDb db) =>
    await db.Scams.ToListAsync());

// Get one scam item by id
app.MapGet("/scamitems/{id}", async (int id, ScamDb db) =>
    await db.Scams.FindAsync(id)
        is Scam scam
            ? Results.Ok(scam)
            : Results.NotFound());

// Add scam item
// TODO: update same phone/email/website counts? 
// May need to create another table (example: ScamCount) for this with just the info and its count, with related Scam Id. 
// We could just get the counts from Scam table every time, but it's not as optimal.
app.MapPost("/scamitems", async (Scam scam, ScamDb db) =>
{
    db.Scams.Add(scam);
    await db.SaveChangesAsync();

    return Results.Created($"/scamitems/{scam.Id}", scam);
});

// Not needed, may be admin feature
// app.MapPut("/scamitems/{id}", async (int id, Scam inputScam, ScamDb db) =>
// {
//     var scam = await db.Scams.FindAsync(id);

//     if (scam is null) return Results.NotFound();

//     scam.ScamDescription = inputScam.ScamDescription;
//     scam.PhoneNumber = inputScam.PhoneNumber;
//     scam.EmailAddress = inputScam.EmailAddress;
//     scam.Website = inputScam.Website;

//     await db.SaveChangesAsync();

//     return Results.NoContent();
// });

// Not full CRUD, we don't delete scam entries. But maybe it should be an admin feature.
// app.MapDelete("/scamitems/{id}", async (int id, ScamDb db) =>
// {
//     if (await db.Scams.FindAsync(id) is Scam scam)
//     {
//         db.Scams.Remove(scam);
//         await db.SaveChangesAsync();
//         return Results.NoContent();
//     }

//     return Results.NotFound();
// });

app.Run();