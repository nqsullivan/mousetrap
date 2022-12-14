using System;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public void Setup()
    {
        Debug.Log("Activating the Pause Screen");
        gameObject.SetActive(true);
    }
    
    public void RestartGame()
    {
        GameManager.Instance.RestartGame();
        GameManager.Instance.Start();
    }
    
    public void ResumeGame()
    {
        GameManager.Instance.Resume();
        gameObject.SetActive(false);
    }
}
