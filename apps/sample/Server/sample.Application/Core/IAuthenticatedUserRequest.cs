using MediatR;

namespace sample.Application.Core;

internal interface IAuthenticatedUserRequest<out TResult> : IRequest<TResult>
{
    /// <summary>
    /// Authenticated user ID
    /// </summary>
    string? AuthUserId { get; set; }
}
