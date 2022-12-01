using UnityEngine.UI;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{

    public Image[] cheeseImages;
    public Sprite negativeCheese;
    public Sprite positiveCheese;

    void Update()
    {

        for (int index = 0; index < GameManager.Instance.score; index++)
        {
            cheeseImages[index].sprite = positiveCheese;
        }

    }
}
