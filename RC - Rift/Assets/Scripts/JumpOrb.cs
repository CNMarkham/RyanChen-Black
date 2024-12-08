using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOrb : MonoBehaviour
{
    public bool inRange;
    public Rigidbody2D rb;
    private float orbForce = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per framess
    void Update()
    {
        if (inRange = true && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, orbForce));
            Debug.Log(inRange);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Orb"))
        {

            inRange = true;
            Debug.Log("dog");
        }
        else
        {
            inRange = false;
            Debug.Log("not dog");
        }
    }
}
