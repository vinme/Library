using ExLib.Application.Interfaces;
using ExLib.Application.ResourceModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExLib.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private IBookTypeService _bookTypeService;
        private IBookStatusService _bookStatusService;
        private IBookLocationService _bookLocationService;
        public MasterController(IBookTypeService bookTypeService, IBookStatusService bookStatusService, IBookLocationService bookLocationService)
        {
            _bookTypeService = bookTypeService;
            _bookStatusService = bookStatusService;
            _bookLocationService = bookLocationService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var bookTypes = _bookTypeService.GetTypeList();
            var bookLocations = _bookLocationService.GetLocationList();
            var bookStatuses = _bookStatusService.GetStatusList();

            MasterResourceModel model = new MasterResourceModel()
            {
                BookTypes = bookTypes,
                BookStatuses = bookStatuses,
                BookLocations = bookLocations
            };

            return Ok(model);
        }
    }
}
