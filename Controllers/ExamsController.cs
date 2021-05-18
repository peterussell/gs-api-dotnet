using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using gs_api.Models;

namespace gs_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private List<Exam> loadExams()
        {
            using (StreamReader sr = new StreamReader("Mocks/pplExams.json"))
            {
              string json = sr.ReadToEnd();
              List<Exam> exams = JsonConvert.DeserializeObject<List<Exam>>(json);
              return exams;
            }
        }

        // GET api/exams
        // [HttpGet("api/exams")]
        public ActionResult<IEnumerable<string>> Get()
        {
          var exams = new List<string>();
          var jsonExams = loadExams();
          jsonExams.ForEach(json => {
            exams.Add(JsonConvert.SerializeObject(json));
          });
          
          return exams;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
