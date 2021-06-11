using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using gs_api.Models.Responses;
using Newtonsoft.Json.Serialization;

namespace gs_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private GetExamsResponse loadExams()
        {
            using (StreamReader sr = new StreamReader("Mocks/pplExams.json"))
            {
              string json = sr.ReadToEnd();
              GetExamsResponse res = JsonConvert.DeserializeObject<GetExamsResponse>(json);
              return res;
            }
        }

        // GET api/exams
        // [HttpGet("api/exams")]
        public ActionResult<string> Get()
        {
            var exams = new List<string>();
            var jsonExams = loadExams();

            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            return JsonConvert.SerializeObject(
              jsonExams,
              new JsonSerializerSettings
              {
                  ContractResolver = contractResolver,
                  Formatting = Formatting.Indented,
              }
            );
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
