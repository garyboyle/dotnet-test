
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnettest.Controllers
{
  [Route("/")]
  public class CampsController
  {

    public object Get()
    {
      return new { Moniker = "moniker value", Name = "name" };
    }
  }
}
