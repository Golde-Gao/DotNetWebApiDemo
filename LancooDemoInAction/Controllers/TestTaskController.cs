using LancooDemoInAction.ModelContexts;
using LancooDemoInAction.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LancooDemoInAction.ViewModel;

namespace LancooDemoInAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestTaskController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ITestTaskRepository _testTaskRep;
        public TestTaskController(ITestTaskRepository testTaskRep, IMapper mapper)
        {
            this._testTaskRep = testTaskRep ?? throw new ArgumentNullException(nameof(testTaskRep));
            this._mapper = mapper ?? throw new ArgumentException(nameof(mapper));
        }
        [HttpGet(template: @"{taskId:int}")]
        //http://localhost:5000/api/TestTask/1000005
        public async Task<ActionResult> GetTestTasks(int taskId)
        {
            var testTask = await this._testTaskRep.GetTestTaskByIDAsync(taskId);
            var testTaskViewModel = this._mapper.Map<TestTaskViewModel>(testTask);
            if (testTask == null)
            {
                return NotFound();
            }
            return Ok(testTaskViewModel);
        }
    }
}
