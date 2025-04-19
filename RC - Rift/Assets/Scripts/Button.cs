using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject button;
    public GameObject buttonActivatedParts;
    public Transform buttonScale;
    public bool isPressed;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Pushbox"))
        {
            if (buttonActivatedParts.activeInHierarchy == false && isPressed == false)
            {
                buttonActivatedParts.SetActive(true);
                isPressed = true;
                Destroy(button);
                Debug.Log("on");
            }
            if(buttonActivatedParts.activeInHierarchy == true && isPressed == false)
            {
                buttonActivatedParts.SetActive(false);
                Destroy(button);
                isPressed = true;
                Debug.Log("off");
            }
            
        }
    }
}
