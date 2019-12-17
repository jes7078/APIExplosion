using System;
using Microsoft.AspNetCore.Mvc;

namespace ApiAPIExplosion.Controllers
{
[ApiController]
[Route("api/[controller]")]

public class ExplosionController : ControllerBase
{
[HttpGet("{str}")]
public ActionResult GetExplosion (string str)
{
  string string2="";
   for (int i=0;i<=str.Length-1;i++)
   {
   for (int j=0;j<char.GetNumericValue(str[i]);j++)
   {
   string2 = string2 + str[i];
   }
   }
   return Ok(string2);

}

}
}





 