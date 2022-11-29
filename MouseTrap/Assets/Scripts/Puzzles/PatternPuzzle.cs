using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatternPuzzle : Puzzle
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    public Canvas miniGameCanvas;

    public override void StartPuzzle()
    {
        Debug.Log("Button Clicked");

        miniGameCanvas.gameObject.SetActive(true);

        
        button1.onClick.AddListener(() =>
        {
            Debug.Log("Button 1 Clicked");
            EndPuzzle(false);
            miniGameCanvas.gameObject.SetActive(false);
            
        });

        button2.onClick.AddListener(() =>
        {
            Debug.Log("Button 2 Clicked");
            EndPuzzle(false);
            miniGameCanvas.gameObject.SetActive(false);

        });


        button3.onClick.AddListener(() =>
        {
            Debug.Log("Button 3 Clicked");
            EndPuzzle(true);
            miniGameCanvas.gameObject.SetActive(false);

        });

        button4.onClick.AddListener(() =>
        {
            Debug.Log("Button 4 Clicked");
            EndPuzzle(false);
            miniGameCanvas.gameObject.SetActive(false);

        });

    } 
}
