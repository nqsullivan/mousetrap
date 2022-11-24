using System.ComponentModel.Design;
using UnityEngine;
public abstract class Puzzle : MonoBehaviour
{
    bool _inRange = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "entered the trigger");
        if(other.gameObject.name == "Jerry")
        {
            _inRange = true;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Jerry")
        {
            _inRange = false;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    
    private void Update()
    {
        if(_inRange && GameManager.Instance.IsRunning())
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            if(Input.GetKeyDown(KeyCode.E))
            {
                StartPuzzle();
            }
        }
    }
    
    public virtual void StartPuzzle()
    {
        //Start the puzzle
    }
    
    public void EndPuzzle(bool success)
    {
        if (success)
        {
            // Increment score and disable puzzle
            Debug.Log("Puzzle completed");
            GameManager.Instance.IncrementScore();
            gameObject.SetActive(false);
        }
    }
}