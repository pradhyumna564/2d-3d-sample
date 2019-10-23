using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int playerScore1 = 0;
    public static int playerScore2 = 0;
    public GUISkin layout;
    GameObject theball;

    // Start is called before the first frame update
    void Start()
    {
        theball = GameObject.FindGameObjectWithTag("Ball");
    }

    public static void Score(string wallID)
    {
        if(wallID == "RightGoal")
        {
            playerScore1++;
        }
        else
        {
            playerScore2++;
        }
        
    }

    public void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + playerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + playerScore2);

        if (GUI.Button(new Rect(Screen.width / 2 - 60, 30, 120, 53),"Restart"))
        {
            playerScore1 = 0;
            playerScore2 = 0;
            theball.SendMessage("Restart", 0.5f, SendMessageOptions.RequireReceiver);
        }

        if (playerScore1 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PlayerOneWins");
            theball.SendMessage("Resetball", null, SendMessageOptions.RequireReceiver);
        }
        else if(playerScore2 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PlayerTwoWins");
            theball.SendMessage("Resetball", null, SendMessageOptions.RequireReceiver);

        }
    }
}

    
