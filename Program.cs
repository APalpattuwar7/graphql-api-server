var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
                .AddQueryType<Query>();
var app = builder.Build();
app.UseRouting().UseEndpoints(endpoints => endpoints.MapGraphQL());

app.MapGet("/", () => "Hello World!");

app.Run();

public record Book(string Title, Author Author);
public record Author(string Name);

public class Query
{
    readonly List<Book> _books = new ()
    {
        new Book("I Love GraphQL", new Author("Brandon M")),
        new Book("GraphQL is the future", new Author("Brandon M")),
        new Book("I Love SOAP + XML", new Author("John Joe"))
    };

    public List<Book> GetBooks() => _books;
}