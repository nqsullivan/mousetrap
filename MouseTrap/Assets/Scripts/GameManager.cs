using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static bool isRunning = true;
    
    public static int score = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // TODO: Setup the main menu
        Debug.Log("Starting the game");
        StartGame(); // We can remove this later when we have a main menu
    }
    
    public void StartGame()
    {
        // TODO: Start the game should be called from the main menu
        isRunning = true;
    }

    public void GameOver()
    {
        // TODO: Setup Game Over Screen
    }

    public void Win()
    {
        // TODO: Setup Win Screen
    }
    
    public void IncrementScore()
    {
        score++;
    }
    
    public bool IsRunning()
    {
        return isRunning;
    }
}
