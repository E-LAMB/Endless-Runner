using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharge : MonoBehaviour
{

    public int sprintspeed = 1;
    public int rushtime = 200;
    public int rush = 1;
    int playerspeed = 0;
    float current = 0.0f;
  
    Rigidbody2D playerObject; 

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 
    void Update()
    {
         
        if (Input.GetKeyDown(KeyCode.LeftShift) && rush == 0)
        {
            rush = rushtime;
            playerObject.velocity = new Vector2 (playerspeed + current, playerObject.velocity.y);
        }

        if (rush != 0)
        {
            rush = rush - 1
        }

        playerObject.velocity = new Vector2 (playerspeed + current, playerObject.velocity.y);

    }
}