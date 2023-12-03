using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class DraftContractController : ControllerBase
{
    IMediator _mediator;

    public DraftContractController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDraftContractRequest request)
    {
        var message = await _mediator.Send(request);
        return Ok(message);
    }
}