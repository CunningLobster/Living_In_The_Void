using Infrastructure.Services;
using Infrastructure.States;

namespace Infrastructure
{
    public class Game
    {
        public readonly GameStateMachine StateMachine;

        public Game(ICoroutineRunner coroutineRunner, LoadingScreen screen)
        {
            StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), screen, AllServices.Container);
        }
    }
}