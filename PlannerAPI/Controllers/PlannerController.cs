using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Models;
using PlannerAPI.Data;

namespace PlannerAPI.Controllers
 
{
    [ApiController]
    [Route("api/Planner")]
    public class PlannerController : Controller
    {
        private readonly plannerAPIDbContext dbContext;

        public PlannerController(plannerAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlans()
        {
            return Ok(await dbContext.Planner.ToListAsync());
            
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetPlan([FromRoute] Guid id)
        {
            var plan = await dbContext.Planner.FindAsync(id);
            if (plan == null)
            {
                return NotFound();
            }
            return Ok(plan);
        }
        [HttpPost]
        public async Task<IActionResult> AddPlan(AddPlanningRequest addPlanRequest)
        {
            var plan = new Plan()
            {
                Id = Guid.NewGuid(),
                className = addPlanRequest.className,
                dueDate = addPlanRequest.dueDate,
                assignmentName = addPlanRequest.assignmentName,
                assignmentWeight = addPlanRequest.assignmentWeight,
            };
            await dbContext.Planner.AddAsync(plan);
            await dbContext.SaveChangesAsync();
            return Ok(plan);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdatePlan([FromRoute] Guid id,UpdatePlanRequest updatePlanRequest)
        {
            var plan = await dbContext.Planner.FindAsync(id);
            if(plan != null)
            {
                plan.dueDate = updatePlanRequest.dueDate;
                plan.assignmentName = updatePlanRequest.assignmentName; 
                plan.assignmentWeight = updatePlanRequest.assignmentWeight;  
                plan.className = updatePlanRequest.className;

                await dbContext.SaveChangesAsync();
                return Ok(plan);
            }
            return NotFound();

        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeletePlan([FromRoute] Guid id)
        {
            var plan = await dbContext.Planner.FindAsync(id);
            if (plan != null)
            {
                dbContext.Remove(plan);
                await dbContext.SaveChangesAsync();
                return Ok(plan);
            }
            return NotFound();
    }
    }
    
}
