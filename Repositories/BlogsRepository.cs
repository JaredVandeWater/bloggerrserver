using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using bloggerrserver.Models;
using Dapper;

namespace bloggerrserver.Repositories
{

  public class BlogsRepository
  {
    private readonly IDbConnection _db;

    public BlogsRepository(IDbConnection db)
    {
      _db = db;
    }


    public List<Blog> GetAll()
    {
      var sql = "SELECT * FROM blogs";
      return _db.Query<Blog>(sql).ToList();
    }

    public Blog GetById(int id)
    {
      string sql = "SELECT * FROM blogs WHERE id = @id";
      return _db.QueryFirstOrDefault<Blog>(sql, new { id });
    }
    public Blog Post(Blog blogData)
    {
      var sql = @"
            INSERT INTO blogs(body)
            VALUES(@Body);
            SELECT LAST_INSERT_ID();
            ";
      int id = _db.ExecuteScalar<int>(sql, blogData);
      blogData.Id = id;
      return blogData;
    }
    public int Put(Blog blogData)
    {
      string sql = @"
                UPDATE blogs SET
                body = @Body
                WHERE id = @id;
                ";
      return _db.Execute(sql, blogData);
    }

    public int delete(int id)
    {
      string sql = @"
      DELETE FROM blogs WHERE id = @id";
      return _db.Execute(sql, new { id });
    }
  }
}