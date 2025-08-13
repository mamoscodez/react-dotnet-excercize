using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ActivitiesController(AppDBContext context) : BaseAPIController
{
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        var activities = await context.Activities.ToListAsync();

        if (activities == null || !activities.Any())
        {
            return NotFound("No activities found.");
        }

        return Ok(activities);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(String id)
    {
        var activity = await context.Activities.FindAsync(id);

        if (activity == null)
        {
            return NotFound("Activity not found.");
        }

        return Ok(activity);
    }
}
