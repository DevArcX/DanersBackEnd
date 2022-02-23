using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class rolPersonaController : ControllerBase
    {

        rolPersonaLogic rolPersonaLogic = new rolPersonaLogic();

        [HttpGet]
        public IActionResult get()
        {
            List<rolPersonaModels> lista = new List<rolPersonaModels>();
            lista = rolPersonaLogic.ListaAll();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            rolPersonaModels model = new rolPersonaModels();
            model = rolPersonaLogic.GetById(id);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult post(rolPersonaModels model)
        {
            rolPersonaModels response = rolPersonaLogic.Create(model);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult put(rolPersonaModels model)
        {
            rolPersonaModels reponse = rolPersonaLogic.Update(model);
            return Ok(reponse);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int response = rolPersonaLogic.Delete(id);
            return Ok(response);
        }
    }
}
