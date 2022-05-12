using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTestIis.Application.Queries;

public static class GetAllRobots
{
    public record Query() : IRequest<List<Robot>>;

    public class Handler : IRequestHandler<Query, List<Robot>>
    {
        private readonly RobotContext _db;
        public Handler(RobotContext db)
        {
            _db = db;
            
        }
        public async Task<List<Robot>> Handle(Query request, CancellationToken cancellationToken) => await _db.Robots.ToListAsync();
    }
}
