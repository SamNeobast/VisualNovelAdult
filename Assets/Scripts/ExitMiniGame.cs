using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMiniGame : MonoBehaviour
{
    public void Exit()
    {
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.PreloadAndPlayAsync("Map").Forget();

        var hidePrinter = new Naninovel.Commands.HidePrinter();
        hidePrinter.ExecuteAsync().Forget();

        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;

        SceneManager.LoadScene("NaniScene");
    }
}
