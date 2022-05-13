namespace BlazorServerTestIis.Endpoints;

public static class RobotEndpointsExtension
{
    public static void MapRobot(this WebApplication app)
    {
        app.MapGet(
            "/api/robot", 
            async (IMediator mediator) 
                => await mediator.Send(new GetAllRobots.Query())
            );
        app.MapGet(
            "/api/robot/{id}", 
            async (IMediator mediator, int id) 
                => await mediator.Send(new GetRobotById.Query(id))
            );
    }
}
