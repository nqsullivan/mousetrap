using UnityEngine;

/**
 * This abstract class is to be used to implement a custom puzzle.
 */
public abstract class Puzzle : MonoBehaviour
{
    bool _inRange = false; // Is the player in range of the puzzle?

    /**
     * This method is called when jerry is in range of the puzzle. It turns the puzzle green.
     * @param other The collider of the object that entered the trigger.
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "entered the trigger");
        if (other.gameObject.name == "Jerry")
        {
            _inRange = true;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    /**
     * This method is called when jerry leaves the range of the puzzle. It turns the puzzle back to red.
     * @param other The collider of the object that exited the trigger.
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Jerry")
        {
            _inRange = false;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    /**
     * This method monitors the player's input and calls the StartPuzzle method if the player is in range and presses the E key.
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    private void Update()
    {
        if (_inRange && GameManager.Instance.isRunning)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameManager.Instance.SetInPuzzle(true);
                StartPuzzle();
            }
        }
    }

    /**
     * This method is called when the player presses the E key while in range of the puzzle. It is abstract and must be
     * implemented in the child puzzle class.
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public virtual void StartPuzzle()
    {
        //Start the puzzle
    }

    /**
     * This method is called when the puzzle is completed. If the param is true, the puzzle is completed, the score is
     * incremented and the puzzle is destroyed. If the param is false the puzzle is closed.
     * @param completed A boolean value that determines if the puzzle is completed or not.
     * @return void
     * @author Nathaniel Sullivan
     * @version November 24th 2022
     */
    public void EndPuzzle(bool success)
    {
        GameManager.Instance.SetInPuzzle(false);
        if (success)
        {
            // Increment score and disable puzzle
            Debug.Log("Puzzle completed");
            GameManager.Instance.IncrementScore();
            gameObject.SetActive(false);
        }
        else
        {
            // TODO: Close puzzle and notify tom that he failed
        }
    }
}