﻿using sample.Core.Cqrs;
using MediatR;

namespace sample.Application.Commands;

public class CreateUserCommand : IRequest<Result>
{
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}
