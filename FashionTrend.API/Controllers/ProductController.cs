using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest request)
    {
        var product = await _mediator.Send(request);
        return Ok(product);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateProductResponse>>
        Update(Guid id, UpdateProductRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
        {
            return BadRequest();
        }
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllProductResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllProductRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetProductByIdResponse>> Get(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null) { return BadRequest(); }

        var request = new GetProductByIdRequest(id.Value);
        var response = await _mediator.Send(request, cancellationToken);

        if (response is null) { return NotFound(); }
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
        {
            return BadRequest();
        }

        var deleteRequest = new DeleteProductRequest(id.Value);
        var response = await _mediator.Send(deleteRequest, cancellationToken);
        return Ok(response);
    }

}