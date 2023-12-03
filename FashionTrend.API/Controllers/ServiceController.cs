using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class ServiceController : ControllerBase
{
    IMediator _mediator;

    public ServiceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateServiceRequest request)
    {
        var service = await _mediator.Send(request);
        return Ok(service);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateServiceResponse>>
        Update(Guid id, UpdateServiceRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
        {
            return BadRequest();
        }
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllServiceResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllServiceRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetServiceByIdResponse>> Get(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null) { return BadRequest(); }

        var request = new GetServiceByIdRequest(id.Value);
        var response = await _mediator.Send(request, cancellationToken);

        if (response is null) { return NotFound(); }
        return Ok(response);
    }

    [HttpGet("type/{type}")]
    public async Task<ActionResult<GetServiceByTypeResponse>> GetByType(RequestType? type, CancellationToken cancellationToken)
    {
        if (type is null) { return BadRequest(); }

        var request = new GetServiceByTypeRequest(type.Value);
        var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
        {
            return BadRequest();
        }

        var deleteRequest = new DeleteServiceRequest(id.Value);
        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
    }
}