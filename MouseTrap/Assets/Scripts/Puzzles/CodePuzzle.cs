using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodePuzzle : Puzzle
{
    public Canvas miniGameCanvas;
    
    public Button b0;
    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b5;
    public Button b6;
    public Button b7;
    public Button b8;
    public Button b9;
    
    public Button bClear;
    public Button bEnter;
    
    public TextMeshProUGUI targetCode;
    public TextMeshProUGUI inputCode;

    public override void StartPuzzle()
    {
        miniGameCanvas.gameObject.SetActive(true);
        
        b0.onClick.AddListener(() => { inputCode.text += "0"; });
        b1.onClick.AddListener(() => { inputCode.text += "1"; });
        b2.onClick.AddListener(() => { inputCode.text += "2"; });
        b3.onClick.AddListener(() => { inputCode.text += "3"; });
        b4.onClick.AddListener(() => { inputCode.text += "4"; });
        b5.onClick.AddListener(() => { inputCode.text += "5"; });
        b6.onClick.AddListener(() => { inputCode.text += "6"; });
        b7.onClick.AddListener(() => { inputCode.text += "7"; });
        b8.onClick.AddListener(() => { inputCode.text += "8"; });
        b9.onClick.AddListener(() => { inputCode.text += "9"; });
    
        bClear.onClick.AddListener(() => { inputCode.text = ""; });
        bEnter.onClick.AddListener(() => { CheckCode(); });
        
        // Generate a random 5 digit code
        targetCode.text = UnityEngine.Random.Range(10000, 99999).ToString();
        inputCode.text = "";
    }
    
    private void CheckCode()
    {
        if (inputCode.text == targetCode.text)
        {
            Debug.Log("Code correct");
            EndPuzzle(true);
            miniGameCanvas.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Code incorrect");
            EndPuzzle(false);
            miniGameCanvas.gameObject.SetActive(false);
        }
    }
}
