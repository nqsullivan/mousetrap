using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Pressed Play");
        GameManager.Instance.StartGame();
        gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
