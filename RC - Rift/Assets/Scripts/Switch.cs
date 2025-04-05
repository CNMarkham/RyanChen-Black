using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool isRed = true; //level starts red
    public bool isBlue = false;
    public bool canSwitch;
    public GameObject red; //all red platforms
    public GameObject blue; //all blue platforms
    public float cooldown = 0.1f;

    public Color backgroundBlue = Color.blue;
    public Color backgroundRed = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isBlue == false && isRed == true && canSwitch == true)
            {
                StartCoroutine(Cooldown(cooldown));
                red.gameObject.SetActive(false);
                blue.gameObject.SetActive(true);
                Camera mainCamera = GetComponent<Camera>();
                mainCamera.backgroundColor = backgroundBlue;
                isBlue = true;
                isRed = false;
                Debug.Log("blue");
            }
            if (isBlue == true && isRed == false && canSwitch == true)
            {
                StartCoroutine(Cooldown(cooldown));
                blue.gameObject.SetActive(false);
                red.gameObject.SetActive(true);
                Camera mainCamera = GetComponent<Camera>();
                mainCamera.backgroundColor = backgroundRed;
                isRed = true;
                isBlue = false;
                Debug.Log("red");
            }
        }
    }

    IEnumerator Cooldown (float seconds)
    {
        canSwitch = false;
        yield return new WaitForSeconds(seconds);
        canSwitch = true;
    }
}
