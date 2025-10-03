namespace TeamServer.Domain.Entities.Listeners
{
    public abstract class ListenerEntity
    {
        public abstract string Name { get; }

        public abstract void Start();
        public abstract void Stop();
    }
}
