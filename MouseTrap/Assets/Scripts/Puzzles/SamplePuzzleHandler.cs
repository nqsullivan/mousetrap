using UnityEngine;
using UnityEngine.UI;

public class SamplePuzzleHandler : Puzzle
{
    public Button button; // A reference to the button on the puzzle the player must click
    public Canvas miniGameCanvas; // A reference to the canvas that contains the mini game

    public override void StartPuzzle() // This method is called when the player interacts with the puzzle
    {
        Debug.Log("Puzzle Started");
        miniGameCanvas.gameObject.SetActive(true); // Show the mini game canvas

        button.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
            EndPuzzle(true); // By sending true to EndPuzzle, we signal that the puzzle was completed successfully
            // If we had sent false, we would have signalled that the puzzle was failed
        });
    }
}