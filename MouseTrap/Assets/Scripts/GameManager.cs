using UnityEngine;

/**
 * This singleton class is used to manage the game
 */
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Singleton instance

    public static bool isRunning = true; // True when not paused, game over, or in main menu
    public static bool inPuzzle = false; // True when in a puzzle
    
    public static int score = 0; // Score = num of puzzles solved

    /**
     * This method is called when the script instance is being loaded and is used to initialize the singleton instance
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
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

    /**
     * This method is called when the script is first loaded and initializes the main menu
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    void Start()
    {
        // TODO: Setup the main menu
        Debug.Log("Starting the game");
        StartGame(); // We can remove this later when we have a main menu
    }
    
    /**
     * When the game is started, this method is called to initialize the game
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void StartGame()
    {
        // TODO: Start the game should be called from the main menu
        isRunning = true;
        
        // Hide mouse cursor and lock it to the center of the screen
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
        // TODO: Setup Game Over Screen
    }

    /**
     * This method is called when the player wins the game
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void Win()
    {
        // TODO: Setup Win Screen
    }
    
    /**
     * This method increments the score by 1. It is called when a puzzle is solved
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void IncrementScore()
    {
        score++;
    }
    
    /**
     * A method to get if the game is running
     * @return bool
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public bool IsRunning()
    {
        return isRunning;
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
        if(b)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
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
}
