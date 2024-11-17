using UnityEngine.SceneManagement;
using Naninovel;
using Naninovel.Commands;

[CommandAlias("MiniGame")]
public class StartMiniGame : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        // Вимикаємо систему вводу Naninovel
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = false;

        // Зупиняємо відтворення Naninovel сценаріїв
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();

        // Ховаємо текстовий інтерфейс
        var hidePrinter = new HidePrinter();
        hidePrinter.ExecuteAsync(asyncToken).Forget();

        // Завантажуємо сцену з міні-грою
        SceneManager.LoadScene("Demo");

        // Вимикаємо Naninovel камеру
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = false;

        // Скидаємо стан UI Naninovel
        var stateManage = Engine.GetService<IUIManager>();
        stateManage.ResetService();

        return UniTask.CompletedTask;
    }
}
