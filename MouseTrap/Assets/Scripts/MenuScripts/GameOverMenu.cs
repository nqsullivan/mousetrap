using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public void Setup()
    {
        Debug.Log("Activating the Game Over Screen");
        gameObject.SetActive(true);
    }
    
    public void RestartGame()
    {
        GameManager.Instance.RestartGame();
        GameManager.Instance.Start();
    }
    
    public void QuitGame()
    {
        GameManager.Instance.QuitGame();
    }
}
