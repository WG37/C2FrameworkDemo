namespace TeamServer.Domain.Entities.Listeners
{
    public class HttpListener : Listener
    {
        public int BindPort { get; set; }
        public override string Name { get; }

        private CancellationTokenSource _tokenSource;

        public HttpListener(string name, int bindPort)
        {
            Name = name;
            BindPort = bindPort;
        }

        public override void Start()
        {
            _tokenSource = new CancellationTokenSource();

            var builder = WebApplication.CreateBuilder();
            builder.WebHost.UseUrls($"http://{Name}:{BindPort}");
            builder.Services.AddControllers();

            var host = builder.Build();

            host.MapControllers();

            host.RunAsync(_tokenSource.Token);
        }

        public override void Stop()
        {
            _tokenSource.Cancel();
        }
    }
}
