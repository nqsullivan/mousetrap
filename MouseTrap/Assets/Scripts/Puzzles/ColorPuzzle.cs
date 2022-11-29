using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections.Generic;

public class ColorPuzzle : Puzzle
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Canvas miniGameCanvas; // A reference to the canvas that contains the mini game

    private const int TOTAL_TILES = 10;

    private int tilesClicked = 0;
    private int numOfTilesToClick = 4;
    private Color targetColor = Color.green;

    public override void StartPuzzle()
    {
        Debug.Log("Color Puzzle Started...");
        miniGameCanvas.gameObject.SetActive(true);

        List<int> indices = new List<int>();
        System.Random gen = new System.Random();

        for (int index = 0; index < numOfTilesToClick; index++)
        {
            int randNum = gen.Next(TOTAL_TILES);
            while (indices.Contains(randNum))
            {
                randNum = gen.Next(TOTAL_TILES);
            }
            indices.Add(randNum);
            Debug.Log("Index of Color Puzzle: " + randNum);
        }

        // Button Handling
        button1.onClick.AddListener(() =>
        {
            if (indices.Contains(1))
            {
                tilesClicked++;
                indices.Remove(1);
                button1.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button2.onClick.AddListener(() =>
        {
            if (indices.Contains(2))
            {
                tilesClicked++;
                indices.Remove(2);
                button2.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button3.onClick.AddListener(() =>
        {
            if (indices.Contains(3))
            {
                tilesClicked++;
                indices.Remove(3);
                button3.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button4.onClick.AddListener(() =>
        {
            if (indices.Contains(4))
            {
                tilesClicked++;
                indices.Remove(4);
                button4.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button5.onClick.AddListener(() =>
        {
            if (indices.Contains(5))
            {
                tilesClicked++;
                indices.Remove(5);
                button5.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button6.onClick.AddListener(() =>
        {
            if (indices.Contains(6))
            {
                tilesClicked++;
                indices.Remove(6);
                button6.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button7.onClick.AddListener(() =>
        {
            if (indices.Contains(7))
            {
                tilesClicked++;
                indices.Remove(7);
                button7.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button8.onClick.AddListener(() =>
        {
            if (indices.Contains(8))
            {
                tilesClicked++;
                indices.Remove(8);
                button8.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button9.onClick.AddListener(() =>
        {
            if (indices.Contains(9))
            {
                tilesClicked++;
                indices.Remove(9);
                button9.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

        // Button Handling
        button10.onClick.AddListener(() =>
        {
            if (indices.Contains(10))
            {
                tilesClicked++;
                indices.Remove(10);
                button10.GetComponent<Image>().color = targetColor;

                if (tilesClicked == numOfTilesToClick)
                {
                    miniGameCanvas.gameObject.SetActive(false); // Hide the mini game canvas
                    EndPuzzle(true);
                }
            }
        });

    }

}
