using LancooDemoInAction.ModelContexts;
using LancooDemoInAction.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancooDemoInAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestTaskController : ControllerBase
    {

        private readonly ITestTaskRepository _testTaskRep;
        public TestTaskController(ITestTaskRepository testTaskRep)
        {
            _testTaskRep = testTaskRep ?? throw new ArgumentNullException(nameof(testTaskRep));
        }
        [HttpGet("{taskId}")]
        //http://localhost:5000/api/TestTask/1000005
        public async Task<ActionResult> GetTestTasks(int taskId)
        {
            var testTask = await this._testTaskRep.GetTestTaskByIDAsync(taskId);
            if (testTask == null)
            {
                return NotFound();
            }
            return Ok(testTask);
        }
    }
}
