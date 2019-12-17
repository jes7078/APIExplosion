using System;
using Microsoft.AspNetCore.Mvc;

namespace ApiAPIExplosion.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MumblingController : ControllerBase
    {
      [HttpGet("{str}")]
      public ActionResult GetMumbling(string str)
      {

string string2="";
     for (int i=0;i<str.Length;i++)
     {
     for (int j=0; j<=i; j++)
     {
     if (j==0) 
     {
     string2=string2+char.ToUpper(str[i]).ToString();
     }
     else
     {
     string2=string2 +char.ToLower(str[i]).ToString();
     }
     }

  if (i<str.Length-1)
     {
     string2=string2 + "-";
     }

     }
     
     return Ok(string2.ToString());
      }
  }
}