using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class PauseMenu : MonoBehaviour
{
    public GameObject options;

    void Update()
    {
        //Open menu when pressing P
        if (Input.GetKeyDown(KeyCode.P))
        {
            options.gameObject.SetActive(true);
        }
    }
}
