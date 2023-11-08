var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var Movies = new List<MovieRecord>
{
            new MovieRecord(
                 1,
                 "Highlander",
                 "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                 "/images/movies/Highlander.png",
                 "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            ),
             new MovieRecord(
                2,
                "Godfather",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                "/images/movies/Godfather.png",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            ),
            new MovieRecord(
                3,
                "Last of the Mohicans",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                "/images/movies/LastOfTheMohicans.png",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            ),
            new MovieRecord(
                4,
                "Rear Window",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                "/images/movies/RearWindow.png",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            ),
            new MovieRecord(
                5,
                "Road House",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                "/images/movies/RoadHouse.png",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            ),
            new MovieRecord(
                6,
                "Star Treck IV",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                "/images/movies/StarTreck4.png",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            )

};


var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/movies", () =>
{   
    return Movies;
})
.WithName("GetMovies")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

record MovieRecord(int Id, string Title, string Description, string ImageUrl, string Review);
