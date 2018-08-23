using Microsoft.AspNetCore.Mvc;
using System;
using WebApi.Builders.Triggers;
using WebApi.Interfaces;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ExerciseController : Controller
    {
        private readonly IExcerciseOutputService _IExcerciseOutputService;

        public ExerciseController(IExcerciseOutputService iExcerciseOutputService)
        {
            _IExcerciseOutputService = iExcerciseOutputService;
        }

        // GET api/exercise
        [HttpGet]
        public IActionResult GetExercise()
        {
            try
            {
                var output = new ExerciseOutput();

                var result = _IExcerciseOutputService.ProcessMockDataOutput(output);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        // POST api/exercise
        [HttpPost]
        public Exercise PostAnswer([FromBody]string value)
        {
            throw new NotImplementedException();
        }
    }
}
