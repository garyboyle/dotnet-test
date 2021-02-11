
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnettest.Controllers
{
  [Produces("application/json")]
  [Route("/")]
  public class BasicController : ControllerBase
  {

    [HttpGet]
    public IActionResult Get(bool withQueryString = false)
    {
      if (withQueryString)
      {
        return Ok(new { message = "This is the base route with query string" });

      }
      else
      {
        return Ok(new { message = "This is the base route" });
      }
    }

    /// <summary>
    /// Add in a summary to the method
    /// </summary>
    /// <param name="urlParam">Give the parameter a description</param>
    /// <returns>A newly created TodoItem</returns>
    /// <response code="201">Desscription of a 201 response code</response>
    /// <response code="400">Desscription of a 400 response code</response>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /param/test
    ///     {
    ///        "message": "test"
    ///     }
    ///
    /// </remarks>
    [HttpGet("/param/{urlParam}")]
    public IActionResult GetItem(string urlParam)
    {
      return Ok(new { message = urlParam });
    }

    [HttpGet("/paramWithType/{urlParam:int}")]
    public IActionResult GetItem(int urlParam)
    {
      return Ok(new { message = urlParam });
    }
  }
}

