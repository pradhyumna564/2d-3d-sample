using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    public void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand <= 0.5)
        {
            rb2d.AddForce(new Vector2(40, 35));
        }
        else
        {
            rb2d.AddForce(new Vector2(-40, -35));
        }
    }

    public void Resetball()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
   
    public void Restart()
    {
        Resetball();
        Invoke("GoBall", 1);
    }

    public void OnCollisionEnter2D(Collision2D  collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2) + (collision.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = vel;
        }
    }
}