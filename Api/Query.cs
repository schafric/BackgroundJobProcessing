using Domain;

namespace Api;

public class Query
{
    public Task<List<Book>> GetBooks([Service] Repository repository) =>
         repository.GetBooksAsync();
}