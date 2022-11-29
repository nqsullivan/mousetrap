using UnityEngine;
using UnityEngine.UI;

public class GameOverHandler : MonoBehaviour
{
    public Button restartButton;
    
    private void Start()
    {
        restartButton.onClick.AddListener(() =>
        {
            GameManager.Instance.RestartGame();
        });
    }
}
