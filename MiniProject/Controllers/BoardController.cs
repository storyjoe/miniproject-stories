using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject.Models;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniProject.Controllers
{
    [Route("api/[controller]")]
    public class BoardController : Controller
    {
        private readonly GoalContext _goalContext;

        public BoardController(GoalContext goalContext)
        {
            _goalContext = goalContext;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> GetGoalItems()
        {
            // return await _goalContext.GoalItems.Include(g => g.StepItems).ToListAsync();
            var result = await _goalContext.Goals.Include(goal => goal.Steps).ThenInclude(step => step.Stories).ToListAsync();

            return Json(result, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
    }
}
