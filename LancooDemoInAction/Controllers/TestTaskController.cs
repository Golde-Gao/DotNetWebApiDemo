using LancooDemoInAction.ModelContexts;
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

        private readonly PContext _context;
        public TestTaskController(PContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        [HttpGet("{taskName}")]
        //https://localhost:5001/api/TestTask/%E8%8B%B1%E8%AF%AD%E8%80%83%E7%82%B9%E8%AF%86%E5%88%AB%E6%B5%8B%E8%AF%95%EF%BC%88%E5%8D%95%E9%80%89%E9%A2%98%EF%BC%898.30
        public async Task<ActionResult> GetTestTasks(string taskName)
        {
            var testTask = await this._context.TaskView.Where(tt => tt.TaskName == taskName).ToListAsync();
            if (testTask == null)
            {
                return NotFound();
            }
            return Ok(testTask);
        }
    }
}
