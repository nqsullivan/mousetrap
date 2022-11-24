using UnityEngine;
using UnityEngine.UI;

public class PuzzleHandler  :  Puzzle
{
    public Button button;
    public Canvas miniGameCanvas;
    
    public override void StartPuzzle()
    {
        Debug.Log("Puzzle Started");
        miniGameCanvas.gameObject.SetActive(true);
        button.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            miniGameCanvas.gameObject.SetActive(false);
            EndPuzzle(true);
        });
    }
}