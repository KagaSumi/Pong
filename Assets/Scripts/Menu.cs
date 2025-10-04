using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameModeData gameModeData; // assign in inspector

    public void StartPlayerVsPlayer()
    {
        gameModeData.selectedMode = GameModeData.Mode.PlayerVsPlayer;
        SceneManager.LoadScene("Game");
    }

    public void StartPlayerVsAI()
    {
        gameModeData.selectedMode = GameModeData.Mode.PlayerVsAI;
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
}
