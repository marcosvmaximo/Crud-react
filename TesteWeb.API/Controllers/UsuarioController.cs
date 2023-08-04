using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TesteWeb.Application.Commands;
using TesteWeb.Application.Queries;

namespace TesteWeb.API.Controllers;

[ApiController]
[Route("v1/usuario")]
public class UsuarioController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsuarioController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpDelete("{id}/pagamento")]
    public async Task<IActionResult> DeletarPagamento([FromRoute] Guid id)
    {
        var request = new ExcluirPagamentoCommand(id);
        var result = await _mediator.Send(request);

        if (result.Code != (int)HttpStatusCode.OK)
            return BadRequest(result);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> BuscarUsuarios()
    {
        var result = await _mediator.Send(new BuscarTodosUsuariosQuery());

        if (result.Code != (int)HttpStatusCode.OK)
            return BadRequest(result);

        return Ok(result);
    }

    [HttpGet("{id}/pagamento")]
    public async Task<IActionResult> BuscarPagamentosPorUsuario([FromRoute] Guid id)
    {
        var result = await _mediator.Send(new BuscarPagamentosPorUsuarioQuery(id));

        if (result.Code != (int)HttpStatusCode.OK)
            return BadRequest(result);

        return Ok(result);
    }
}

