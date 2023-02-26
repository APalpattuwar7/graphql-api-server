public class Query
{
    readonly List<Book> _books = new ()
    {
        new Book("I Love GraphQL", new Author("Brandon M")),
        new Book("GraphQL is the future", new Author("Brandon M")),
        new Book("I Love SOAP + XML", new Author("John Joe"))
    };

    public List<Book> GetBooks() => _books;

    public Book GetBook(string title) => _books.FirstOrDefault(x => x.Title == title);

    public Author GetAuthor(string name) => _books.Where(x => x.Author.Name == name).FirstOrDefault().Author;
}