using BillingSystemManagement.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/billing")]
public class BillingController : ControllerBase
{
    private readonly BillingService _service;

    public BillingController(BillingService service)
    {
        _service = service;
    }

    [HttpPost("generate")]
    public IActionResult Generate(string type, decimal usage, decimal rate)
    {
        var amount = _service.GenerateBill(type, usage, rate);
        var finalAmount = _service.ApplyDiscounts(amount);

        var invoice = new Invoice(finalAmount);

        return Ok(invoice);
    }
}
namespace BillingSystemManagement.Controllers
{
    public class billinfcontoller
    {
    }
}
