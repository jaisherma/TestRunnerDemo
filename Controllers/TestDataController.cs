using Microsoft.AspNetCore.Mvc;

namespace TestRunnerDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDataController : ControllerBase
    {
        public TestDataController()
        {
        }

        [HttpGet]
        public ActionResult<List<TestData>> Get()
        {
            var data = new List<TestData>
            {
                new TestData
                {
                    Id = 4,
                    Name = "Test 1"
                },
                new TestData
                {
                    Id = 5,
                    Name = "Test 2"
                },
            };

            return this.Ok(data);
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return new ContentResult
            {
                StatusCode = 400,
                Content = "Delete is not supported"
            };
        }
    }
}