using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using model_binding_attributes.Models;

namespace model_binding_attributes.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index([Bind("name,family,age")]Person person)
        {
            person.id = 202;
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            return Ok(person);
        }
        public IActionResult Index2(int id,string name,string family,[BindRequired]int age)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok("ok");
        }

        public IActionResult Index3(Person person)
        {
            person.id = 45;
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(person);
        }
        public IActionResult Index4([FromQuery]Person person)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(person);
        }

        public IActionResult Index5([FromRoute]int id, [FromQuery]string name, [FromQuery] string family, [BindRequired][FromQuery] int age)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok("ok");
        }
    }
}
