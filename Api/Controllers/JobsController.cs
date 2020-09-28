using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model;
using Business.Abstract;
using Business.Concrate;
using DataAccess;
using DataAccess.Contexts;
using DataAccess.Repositories;
using DataAccess.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController:ControllerBase
    {
        private IAdvertisementService _advertisementService;
        public JobsController(IAdvertisementService advertisementService)
        {
            _advertisementService=advertisementService;
        }
        /*
        [HttpGet()]
        public async Task<ActionResult<List<Advertisement>>> Get()
        {
            var jobs =await _advertisementService.GetAdvertisemetsAsync(); 
            return Ok(jobs);
        }
        */
        
        [HttpGet("{id}")]
        public async Task<Advertisement> Get(int id)
        {
            return await _advertisementService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<ActionResult> Add(Advertisement advertisement)
        {
            await _advertisementService.AddAdvertisementAsync(advertisement);
            return Ok("Added");
        }
        [HttpGet()]
        public async Task<ActionResult<List<Advertisement>>> Get([FromQuery] JobsParameter jobsParameter)
        {
            if (jobsParameter.advertisementTitle == null && jobsParameter.JobType==null && jobsParameter.Location==null)
            {
                var jobs = await _advertisementService.GetAdvertisemetsAsync(); 
                return Ok(jobs);
            }
            else
            {
                AdvertisementContext _context = new AdvertisementContext();
               // var jobs = await _context.Advertisements.Where(c => c.JobType.ToLower() == jobsParameter.JobType.ToLower() 
                //&& c.AdvertisementTitle.ToLower() == jobsParameter.JobTitle.ToLower() && c.Location == jobsParameter.Location).ToListAsync();
                var result = _context.Advertisements.AsQueryable();
                if (jobsParameter != null)
                {
                    if (!string.IsNullOrEmpty(jobsParameter.Location))
                        result = result.Where(x => x.Location.ToLower() == jobsParameter.Location.ToLower());
                    if (!string.IsNullOrEmpty(jobsParameter.JobType))
                        result = result.Where(x => x.JobType.ToLower() == jobsParameter.JobType.ToLower());
                    if (!string.IsNullOrEmpty(jobsParameter.advertisementTitle))
                        result = result.Where(x => x.AdvertisementTitle.ToLower().Contains(jobsParameter.advertisementTitle.ToLower()));
                } 
                return Ok(await result.ToListAsync());
            }
        }
    }
}