using System;
using System.Collections.Generic;
using bloggerrserver.Models;
using bloggerrserver.Repositories;

namespace bloggerrserver.Services
{
  public class BlogsService
  {


    private readonly BlogsRepository _Repo;

    public BlogsService(BlogsRepository Repo)
    {
      _Repo = Repo;
    }


    public List<Blog> GetAll()
    {
      return _Repo.GetAll();
    }

    public Blog GetById(int id)
    {
      return _Repo.GetById(id);
    }

    public Blog Post(Blog blogData)
    {
      return _Repo.Post(blogData);
    }

    public Blog Put(int id, Blog blogData)
    {
      blogData.Id = id;
      Blog original = GetById(id);
      blogData.Body = blogData.Body == null ? original.Body : blogData.Body;
      int updated = _Repo.Put(blogData);
      if (updated > 0)
      {
        return blogData;
      }
      else
      {
        throw new Exception("Update Failed");
      }
    }

    public string Delete(int id)
    {
      int updated = _Repo.delete(id);
      if (updated > 0)
      {
        return "Deleted";
      }
      else
      {
        throw new System.Exception("could not delete");
      }

    }
  }
}