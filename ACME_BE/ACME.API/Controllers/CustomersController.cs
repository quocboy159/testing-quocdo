using ACME.LOGIC.Common;
using ACME.LOGIC.Queries.Customers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ACME.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(Constants.PolicyName)]
    public class CustomersController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        public CustomersController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _dispatcher.Dispatch(new GetCustomerListQuery());
            return Ok(result);
        }
    }
}
