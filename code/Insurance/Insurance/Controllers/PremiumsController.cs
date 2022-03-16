using Insurance.Models;
using Insurance.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Insurance.Api.Controllers
{
    [Route("premiums")]
    [ApiController]
    public class PremiumsController : ControllerBase
    {
        private readonly IPremiumService _premiumService;
        public PremiumsController(IPremiumService premiumService)
        {
          
            _premiumService = premiumService;
        }
        [HttpPost()]
        [ProducesResponseType(typeof(MonthlyPremiumModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public IActionResult CalculateMonthlyPremium(CustomerModel customerModel, CancellationToken cancellationToken)
        {
            return Ok(_premiumService.Calculate(customerModel.Age, customerModel.Occupation, customerModel.SumInsured));
        }
    }
}
