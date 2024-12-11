using Cseresznye_OSY2WW.BookModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cseresznye_OSY2WW.Controllers
{
    [Route("api/color")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        // GET: api/<ColorController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.ColorsAndMeanings.ToList());
        }

        // GET api/<ColorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var keres = (from x in context.ColorsAndMeanings
                         where x.ColorId == id
                         select x).FirstOrDefault();
            if (keres == null)
            {
                return NotFound("Nincs ilyen");
            }
            return Ok(keres);
        }

        // POST api/<ColorController>
        [HttpPost]
        public IActionResult Post([FromBody] ColorsAndMeaning újszín)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            context.ColorsAndMeanings.Add(újszín);
            context.SaveChanges();
            return Ok("Sikeres felvétel");
        }

        // PUT api/<ColorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ColorsAndMeaning value)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var mod = (from x in context.ColorsAndMeanings
                         where x.ColorId == id
                         select x).FirstOrDefault();
            if (mod == null) {
                return NotFound("Nincs ilyen");
            }

            mod.Color = value.Color;
            mod.Culture = value.Culture;
            mod.Meaning = value.Meaning;
            mod.IsPositive = value.IsPositive;

            context.SaveChanges();
            return Ok("Siker");
        }

        // DELETE api/<ColorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var del = (from x in context.ColorsAndMeanings
                       where x.ColorId == id
                       select x).FirstOrDefault();

            if (del == null)
            {
                return NotFound("Nincs ilyen");
            }
            context.Remove(del);
            context.SaveChanges();
            return Ok("Sikeres törlés");
        }
    }
}
