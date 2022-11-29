using UnityEngine;
using UnityEngine.UI;

public class ClickTheButtons2 : Puzzle
{
    public Button firstButton;
    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Canvas miniGameCanvas; // A reference to the canvas that contains the mini game

    

    /**
     * This method is used to start a puzzle where the player simply has to click 11 buttons as they appear
     * @return void
     * @author Tommy Nguyen
     * @version November 29th 2022
     */
    public override void StartPuzzle() // This method is called when the player interacts with the puzzle
    {
        Debug.Log("Puzzle Started");
        miniGameCanvas.gameObject.SetActive(true); // Show the mini game canvas

        firstButton.onClick.AddListener(() =>
        {
            firstButton.gameObject.SetActive(false);
            button0.gameObject.SetActive(true);
        });

        button0.onClick.AddListener(() =>
        {
            button0.gameObject.SetActive(false);
            button1.gameObject.SetActive(true);
        });

        button1.onClick.AddListener(() =>
        {
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(true);
        });

        button2.onClick.AddListener(() =>
        {
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(true);
        });

        button3.onClick.AddListener(() =>
        {
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(true);
        });

        button4.onClick.AddListener(() =>
        {
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(true);
        });

        button5.onClick.AddListener(() =>
        {
            button5.gameObject.SetActive(false);
            button6.gameObject.SetActive(true);
        });

        button6.onClick.AddListener(() =>
        {
            button6.gameObject.SetActive(false);
            button7.gameObject.SetActive(true);
        });

        button7.onClick.AddListener(() =>
        {
            button7.gameObject.SetActive(false);
            button8.gameObject.SetActive(true);
        });

        button8.onClick.AddListener(() =>
        {
            button8.gameObject.SetActive(false);
            button9.gameObject.SetActive(true);
        });

        button9.onClick.AddListener(() =>
        {
            miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
            EndPuzzle(true);
        });
    }
}