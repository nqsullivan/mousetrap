using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Setup()
    {
        Debug.Log("Activating the MainMenu Screen");
        gameObject.SetActive(true);
    }
    
    public void StartGame()
    {
        GameManager.Instance.StartGame();
        gameObject.SetActive(false);
    }
    
    public void QuitGame()
    {
        GameManager.Instance.QuitGame();
    }
}
