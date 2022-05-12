namespace BlazorServerTestIis.Application.Commands;

public static class DeleteRobot
{
    public record Command(int Id) : IRequest;

    public class Handler : AsyncRequestHandler<Command>
    {
        private readonly RobotContext _db;
        public Handler(RobotContext db)
        {
            _db = db;
        }

        protected override async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var robot = await _db.Robots.FindAsync(request.Id);
            if(robot is not null)
            {
                _db.Robots.Remove(robot);
                await _db.SaveChangesAsync();
            }
        }
    }
}
