using LancooDemoInAction.ModelContexts;
using LancooDemoInAction.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancooDemoInAction.Services
{
    public class TestTaskRepository : ITestTaskRepository
    {
        private readonly PContext _context;
        public TestTaskRepository() { }
        public TestTaskRepository(PContext context)
        {
            this._context = context ?? throw new ArgumentNullException();
        }
        public async Task<TaskView> GetTestTaskByIDAsync(int taskID) => await this._context.TaskView.FirstOrDefaultAsync(tt => tt.TaskId == taskID);

    }
}
