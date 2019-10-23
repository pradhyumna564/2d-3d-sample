using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            collider.gameObject.SendMessage("Restart", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
