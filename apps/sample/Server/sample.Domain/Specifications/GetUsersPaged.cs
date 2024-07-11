using System.Linq.Expressions;
using sample.Domain.Core;
using sample.Domain.Entities;

namespace sample.Domain.Specifications;

public class GetUsersPaged : BaseSpecification<User>
{
    public GetUsersPaged(
        string? orderBy,
        int page,
        int pageSize)
    {
        ApplyOrderBy(orderBy);
        ApplyPaging(page, pageSize);
    }
    
    protected override Expression<Func<User, object?>> CreateOrderByExpression(string propertyName)
    {
        return propertyName switch
        {
            "phonenumber" => i => i.PhoneNumber,
            _ => i => i.Email
        };
    }
}
