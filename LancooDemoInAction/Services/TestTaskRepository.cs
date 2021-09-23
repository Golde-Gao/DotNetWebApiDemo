using LancooDemoInAction.Helpers;
using LancooDemoInAction.ModelContexts;
using LancooDemoInAction.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LancooDemoInAction.ViewModelParameter;

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
        public async Task<TaskView> GetTestTaskByIdAsync(int taskId) => 
            await this._context.TaskView.FirstOrDefaultAsync(tt => tt.TaskId == taskId);
        
        public async Task<PagedList<TaskView>> GetCompaniesAsync(TestTaskViewModelParameter parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var queryExpression = _context.TaskView as IQueryable<TaskView>;

            if (!string.IsNullOrWhiteSpace(parameters.TaskName))
            {
                parameters.TaskName = parameters.TaskName.Trim();    
                queryExpression = queryExpression.Where(x =>x.TaskName.Contains( parameters.TaskName));
            }
            
            return await PagedList<TaskView>.CreateAsync(queryExpression, parameters.PageIndex, parameters.PageSize);
        }
    }
}
