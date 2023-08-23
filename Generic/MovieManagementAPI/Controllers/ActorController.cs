using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.DataAccess.Implementation;
using MovieManagement.Domain.Entities.Repository;

namespace MovieManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;    
        public ActorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var actorsFreomRepo = _unitOfWork.Actor.GetAll();
            return Ok(actorsFreomRepo);
        }

        [HttpGet("movies")]
        public ActionResult GetWithMovies()
        {
            var actorsFreomRepo = _unitOfWork.Actor.GetActorsWithMovies();
            return Ok(actorsFreomRepo);
        }
    }
}
