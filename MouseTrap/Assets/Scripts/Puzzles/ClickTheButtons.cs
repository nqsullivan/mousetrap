using UnityEngine;
using UnityEngine.UI;

public class ClickTheButtons : Puzzle
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Canvas miniGameCanvas; // A reference to the canvas that contains the mini game

    private int buttonCounter = 0;

    /**
     * This method is used to start a puzzle where the player simply has to click on 8 buttons
     * @return void
     * @author Tommy Nguyen
     * @version November 26th 2022
     */
    public override void StartPuzzle() // This method is called when the player interacts with the puzzle
    {
        Debug.Log("Puzzle Started");
        miniGameCanvas.gameObject.SetActive(true); // Show the mini game canvas

        button1.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button1.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        button2.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button2.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        button3.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button3.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        button4.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button4.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        button5.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button5.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        button6.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button6.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        button7.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button7.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        button8.onClick.AddListener(() =>
        {
            Debug.Log("Button Clicked");
            buttonCounter++;
            button8.gameObject.SetActive(false);
            if (buttonCounter == 8)
            {
                miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                EndPuzzle(true);
            }
        });

        
    }
}
