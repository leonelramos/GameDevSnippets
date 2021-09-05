namespace PlayerSystems
{
    public class GroundedState : IPlayerState
    {
        public GroundedState(Actor player)
        {
            Player = player;
        }

        public Actor Player { get; }

        public void Execute()
        {
            
        }

        public void QueueAction(PlayerAction action, int actionValue)
        {
            
        }
    }
}