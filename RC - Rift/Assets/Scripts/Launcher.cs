using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Rigidbody2D rb;
    public float launcherForce;
    public bool contact;
    public float angle = 45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Quaternion Rotation = Quaternion.Euler(0, 0, angle);
            rb.AddForce(Rotation * Vector2.up * launcherForce, ForceMode2D.Impulse);
            //Vector2 velocity = rb.velocity;
            //velocity = transform.up * Time.deltaTime * 10;
            //rb.velocity = velocity;
            //push player in the direction of the launcher by a specified force
        }

    }
}
