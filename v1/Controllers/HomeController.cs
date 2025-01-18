using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using v1.DbContexts.Models;
using v1.DTOs;
using v1.Repository.IRepository;
using v1.Services;

namespace v1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        // interface
        private readonly IPublicInterface _publicinterface;
        //service
        //private readonly PublicService _publicService;
        public HomeController(IPublicInterface publicInterface  )
        {
            _publicinterface =publicInterface;
            

        }

        [HttpGet]
        [Route("get-public-data" , Name ="getPublicData")]
        public async Task<IActionResult> GetPublicData()
        {
            dynamic responseInterface =await _publicinterface.GetPublicDataAsync();

            if (responseInterface == null)
            {
                return NotFound();
            }

            // service 


            //var responseServcie = await _publicService.PublicServiceData();

            return Ok(new ApiResponseDto<dynamic>
            {
                Status = true,
                Message = "Public data retrieve successfully.",
                Data = responseInterface
            }) ;
        }
    }
}
