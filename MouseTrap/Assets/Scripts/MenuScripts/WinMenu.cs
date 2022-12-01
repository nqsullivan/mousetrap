using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    public void Setup()
    {
        Debug.Log("Activating the Win Screen");
        gameObject.SetActive(true);
    }
    
    public void RestartGame()
    {
        GameManager.Instance.RestartGame();
        GameManager.Instance.Start();
    }
    
    public void Quit()
    {
        GameManager.Instance.QuitGame();
    }
}
