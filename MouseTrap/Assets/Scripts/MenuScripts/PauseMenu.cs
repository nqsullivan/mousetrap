using System;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button resumeButton;
    private void Start()
    {
        resumeButton.onClick.AddListener(() =>
        {
            Debug.Log("Resume key pressed");
            GameManager.Instance.Resume();
        });
    }
}
