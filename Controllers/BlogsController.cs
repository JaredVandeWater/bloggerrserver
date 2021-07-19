using System.Collections.Generic;
using bloggerrserver.Models;
using bloggerrserver.Services;
using Microsoft.AspNetCore.Mvc;

namespace bloggerrserver.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class BlogsController : ControllerBase
  {

    private readonly BlogsService _bs;
    public BlogsController(BlogsService bs)
    {
      _bs = bs;
    }

    [HttpGet]

    public ActionResult<List<Blog>> GetAll()
    {
      try
      {
        var allBlogs = _bs.GetAll();
        return Ok(allBlogs);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<List<Blog>> GetById(int id)
    {
      try
      {
        var blog = _bs.GetById(id);
        return Ok(blog);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }

    [HttpPost]
    public ActionResult<Blog> Post([FromBody] Blog blogData)
    {
      try
      {
        Blog newBlog = _bs.Post(blogData);
        return Ok(newBlog);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }

    [HttpPut("{id}")]
    public ActionResult<Blog> Put(int id, [FromBody] Blog blogData)
    {
      try
      {
        return Ok(_bs.Put(id, blogData));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }

    [HttpDelete("{id}")]
    public ActionResult<Blog> Delete(int id)
    {
      try
      {
        return Ok(_bs.Delete(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }

    }
  }
}