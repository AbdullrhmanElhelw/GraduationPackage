using Application.Abstractions.Messaging;
using Application.ApplicationServices.DTOs.PatientsDTOs;

namespace Application.Commands.PatientCommands;

public sealed record CreatePatientCommand(CreatePatientDTO CreatePatient) : ICommand;