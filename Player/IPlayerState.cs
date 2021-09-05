namespace PlayerSystems
{
    public interface IPlayerState
    {
        public Actor Player { get; }
        void Execute();
        void QueueAction(PlayerAction action, int actionValue);
    }
}