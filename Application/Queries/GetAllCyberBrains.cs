using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTestIis.Application.Queries;

public static class GetAllCyberBrains
{
    public record Query() : IRequest<List<CyberBrain>>;

    public class Handler : IRequestHandler<Query, List<CyberBrain>>
    {
        private readonly RobotContext _db;
        
        public Handler(RobotContext db)
        {
            _db = db;  
        }
        public async Task<List<CyberBrain>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _db.CyberBrains.ToListAsync();
        }
    }
}
