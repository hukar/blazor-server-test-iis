namespace BlazorServerTestIis.Application.Commands;

public static class AddRobot
{
    public record Command(string code, int power, CyberBrain cyberBrain) : IRequest<Response>;

    public class Handler : IRequestHandler<Command, Response>
    {
        private readonly RobotContext _db;

        public Handler(RobotContext db)
        {
            _db = db;
        }

        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var cyberBrain = await _db.CyberBrains.FindAsync(request.cyberBrain.Id);
            
            var robot = new Robot { Code = request.code, Power = request.power, CyberBrain = request.cyberBrain};

            _db.Add(robot);
            await _db.SaveChangesAsync();
            return new Response(robot.Id);
        }
    }

    public record Response(int id);
}
