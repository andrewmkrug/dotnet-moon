﻿using sample.Core.Cqrs;
using MediatR;

namespace sample.Application.Commands;

public class UpdateUserCommand : IRequest<Result>
{
    public string? Id { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}
