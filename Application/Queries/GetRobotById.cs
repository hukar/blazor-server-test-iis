namespace BlazorServerTestIis.Application.Queries;

public static class GetRobotById
{
    public record Query(int id) : IRequest<Robot?>;

    public class Handler : IRequestHandler<Query, Robot?>
    {
        private readonly RobotContext _db;
        public Handler(RobotContext db)
        {
            _db = db;
        }
        public async Task<Robot?> Handle(Query request, CancellationToken cancellationToken) 
            => await _db.Robots.Where(r => r.Id == request.id).Include(r => r.CyberBrain).FirstOrDefaultAsync();
    }
}
