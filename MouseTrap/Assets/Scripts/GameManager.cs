using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 * This singleton class is used to manage the game
 */
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Singleton instance

    public bool isRunning = false; // True when not paused, game over, or in main menu
    public bool inPuzzle = false; // True when in a puzzle
    
    public int numberOfPuzzles = 4; // Number of puzzles in the game
    public int score = 0; // Score = num of puzzles solved
    public int lives = 3;

    public PauseMenu pauseMenu;
    public MainMenu mainMenu;
    public GameOverMenu gameOverMenu;
    public WinMenu winMenu;
    public GameObject gameOverlay;

    /**
     * This method is called when the script instance is being loaded and is used to initialize the singleton instance
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    /**
     * This method is called every frame and is used for input
     * @return void
     * @author Nathaniel Sullivan
     * @version November 28th 2022
     */
    private void Update()
    {
        // Handle P key
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isRunning)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    /**
     * This method is called when the script is first loaded and initializes the main menu
     * @return void
     * @author Nathaniel Sullivan
     * @version November 28th 2022
     */
    public void Start()
    {
        Debug.Log("Start");
        mainMenu.Setup();
    }
    
    /**
     * When the game is started, this method is called to initialize the game
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void StartGame()
    {
        isRunning = true;
        // Hide mouse cursor and lock it to the center of the screen
        gameOverlay.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    /**
     * This method is called when the game is over
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void GameOver()
    {
        gameOverlay.SetActive(false);
        SetIsRunning(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOverMenu.Setup();
    }

    /**
     * This method is called when the player wins the game
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void Win()
    {
        gameOverlay.SetActive(false);
        SetIsRunning(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        winMenu.Setup();
    }
    
    /**
     * This method increments the score by 1. It is called when a puzzle is solved
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void IncrementScore()
    {
        Debug.Log("Incrementing Score to " + (score + 1) + " out of " + numberOfPuzzles);
        if(score + 1 >= numberOfPuzzles)
        {
            Win();
        }
        else
        {
            score++;
        }
    }
    
    /**
     * A method to set if the player is in a puzzle. This is used to activate/deactivate mouse use
     * @param bool inPuzzle
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void SetInPuzzle(bool b)
    {
        if (b)
        {
            gameOverlay.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            gameOverlay.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        inPuzzle = b;
    }
    
    /**
     * A method to get if the player is in a puzzle
     * @return bool
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public bool IsInPuzzle()
    {
        return inPuzzle;
    }

    /**
     * A method to pause the game
     * @author Nathaniel Sullivan
     * @version November 28th 2022
     */
    public void Pause()
    {
        gameOverlay.SetActive(false);
        SetIsRunning(false);
        pauseMenu.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    /**
     * A method to resume the game from a Pause
     * @author Nathaniel Sullivan
     * @version November 28th 2022
     */
    public void Resume()
    {
        SetIsRunning(true);
        pauseMenu.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void SetIsRunning(bool b)
    {
        isRunning = b;
    }

    public void RestartGame()
    {
        // Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DecrementLives()
    {
        if (lives > 1)
        {
            lives--;
        }
        else
        {
            GameOver();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
