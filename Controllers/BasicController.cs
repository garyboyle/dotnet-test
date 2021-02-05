
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnettest.Controllers
{
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

