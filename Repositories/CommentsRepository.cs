using System.Data;

namespace bloggerrserver.Repositories
{

  public class CommentsRepository
  {
    private readonly IDbConnection _db;

    public CommentsRepository(IDbConnection db)
    {
      _db = db;
    }

  }
}