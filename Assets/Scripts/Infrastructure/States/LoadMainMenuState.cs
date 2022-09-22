namespace Infrastructure.States
{
  public class LoadMainMenuState :IPayloadedState<string>
  {
    private readonly GameStateMachine _stateMachine;
    private readonly SceneLoader _sceneLoader;
    private readonly LoadingScreen _screen;

    public LoadMainMenuState(GameStateMachine stateMachine, SceneLoader sceneLoader, LoadingScreen screen)
    {
      _stateMachine = stateMachine;
      _sceneLoader = sceneLoader;
      _screen = screen;
    }

    public void Enter(string sceneName)
    {
      _screen.Show();
      _sceneLoader.Load(sceneName, OnLoaded);
    }

    public void Exit() => 
      _screen.Hide();

    private void OnLoaded()
    {
      _stateMachine.Enter<MainMenuState>();
    }
  }
}