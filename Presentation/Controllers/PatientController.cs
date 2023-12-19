using Application.ApplicationServices.DTOs.PatientsDTOs;
using Application.Commands.PatientCommands;
using Application.Queries.PatientQueries.GetAllPatient;
using Application.Queries.PatientQueries.GetPatientById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientController : ApiController
{
    private readonly ISender _sender;
    public PatientController(ISender sender) : base(sender)
    {
        _sender = sender;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatientByIdQuery(int id, CancellationToken cancellationToken)
    {
        var query = new GetPatientByIdQuery(id);
        var result = await _sender.Send(query, cancellationToken);
        return result.IsSuccess ? Ok(result) : HandleFailure(result);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllPatients(CancellationToken cancellationToken)
    {
        var query = new GetAllPatientQuery();
        var result = await _sender.Send(query, cancellationToken);
        return result.IsSuccess ? Ok(result) : HandleFailure(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePatient([FromBody] CreatePatientDTO createPatientDTO
        , CancellationToken cancellationToken)
    {
        var command = new CreatePatientCommand(createPatientDTO);
        var result = await _sender.Send(command, cancellationToken);
        if (result.IsFailure)
            return HandleFailure(result);

        return result.IsSuccess ? Ok(result) : HandleFailure(result);
    }

}
