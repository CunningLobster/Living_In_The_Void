using Infrastructure.States;
using UnityEngine;
using UnityEngine.Serialization;

namespace Infrastructure
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        public LoadingScreen LogoScreen;
        
        private Game _game;

        private void Awake()                    
        {
            _game = new Game(this, LogoScreen);
            _game.StateMachine.Enter<BootstrapState>();

            DontDestroyOnLoad(this);
        }
    }
}