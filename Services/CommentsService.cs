using System;
using bloggerrserver.Models;
using bloggerrserver.Repositories;

namespace bloggerrserver.Services
{
  public class CommentsService
  {


    private readonly CommentsRepository _Repo;

    public CommentsService(CommentsRepository Repo)
    {
      _Repo = Repo;
    }


    internal object GetAll()
    {
      throw new NotImplementedException();
    }

    internal object GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal Comment Post(Comment commentData)
    {
      throw new NotImplementedException();
    }

    internal object Put(int id, Comment commentData)
    {
      throw new NotImplementedException();
    }

    internal object Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}