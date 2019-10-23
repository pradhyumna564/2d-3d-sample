using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed;
    public float maxY;
    private Rigidbody2D rb;
    //public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //direction = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb.velocity;
        if (Input.GetKey(moveUp))
        {
            //transform.Translate(direction * speed * Time.deltaTime);
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            //one method to move
            //transform.Translate(direction * -speed * Time.deltaTime);
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        rb.velocity = vel;
        var pos = transform.position;
        if (pos.y > maxY)
        {
            pos.y = maxY;
        }
        else if (pos.y < -maxY)
        {
            pos.y = -maxY;
        }
        transform.position = pos;
    }
}
