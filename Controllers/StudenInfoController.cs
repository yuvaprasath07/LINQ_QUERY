using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentInfo;

namespace JSON_LINQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudenInfoController : ControllerBase
    {
        private readonly IStudentLogicLayer studentLogicLayer;

        public StudenInfoController(IStudentLogicLayer _studentLogicLayer)
        {
            studentLogicLayer= _studentLogicLayer;
        }

        [HttpGet("StudentDetails")]
        public IActionResult getStudent()
        {
            var data = studentLogicLayer.getAll();
            return Ok(data);
        }

        [HttpGet("FoodProduct")]
        public IActionResult GetProduct()
        {
            var data=studentLogicLayer.GetProduct();
            return Ok(data);
        }

    }
}
