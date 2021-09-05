using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerSystems
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputActionAsset _playerActionAsset;
        [SerializeField] private Actor _player;
        [SerializeField] private ActorModel _model;

        private PlayerInputAction _inputAction;
        private PlayerStateMachine _stateMachine;
        private Kinematics _kinematics;
        
        private void Start()
        {
            _inputAction = gameObject.AddComponent<PlayerInputAction>();
            _inputAction.Init(_playerActionAsset);
            _model = new ActorModel();
            _kinematics = new Kinematics(Integrators.ConstantAccel, transform.position);
            _player = new Actor(transform, _model, _kinematics);
            _stateMachine = new PlayerStateMachine(_player, new GroundedState(_player));
        }

        private void Update()
        {
            PlayerAction playerInputAction;
            int playerActionValue;

            UpdateInputPlayerAction(out playerInputAction, out playerActionValue);
            UpdateStateMachine(playerInputAction, playerActionValue);
            UpdateKinematics();
            UpdatePlayer();
        }

        private void UpdateInputPlayerAction(out PlayerAction playerInputAction, out int playerActionValue)
        {
            playerInputAction = _inputAction.Action;
            playerActionValue = _inputAction.ActionValue;
            _inputAction.UpdateAction();
        }

        private void UpdateStateMachine(PlayerAction playerInputAction, int playerActionValue)
        {
            _stateMachine.QueueInputAction(playerInputAction, playerActionValue);
            _stateMachine.Execute();
        }

        private void UpdateKinematics()
        {
            _kinematics.Position = _player.Transform.position;
            _kinematics.DeltaTime = Time.deltaTime;
            _kinematics.Integrate();
        }

        private void UpdatePlayer()
        {
            _player.Transform.position = _kinematics.Position;
        }
    }
}
