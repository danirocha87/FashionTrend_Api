using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    IMediator _mediator;

    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<GetSupplierByIdResponse>> GetByEmail(GetSupplierByEmailRequest request, CancellationToken cancellationToken)
    {

        var response = await _mediator
            .Send(new GetSupplierByEmailRequest(request.Email, request.Password), cancellationToken);

        if (response is null) { return Unauthorized(); }
        return Ok(response);
    }

}
