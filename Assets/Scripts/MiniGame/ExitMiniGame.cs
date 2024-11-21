using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMiniGame : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    public void Exit()
    {
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.PreloadAndPlayAsync("AliceHomeAfterMiniGame").Forget();

        var hidePrinter = new Naninovel.Commands.HidePrinter();
        hidePrinter.ExecuteAsync().Forget();

        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;

        SceneManager.LoadScene("NaniScene");
    }


    public void CloseCanvas()
    {
        canvas.gameObject.SetActive(false);
    }
}
