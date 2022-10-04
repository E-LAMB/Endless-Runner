using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMoving : MonoBehaviour
{

    public float startspeed = 7.0f;
    public float maxspeed = 10f;
    public float incrementspeed = 0.1f;

    public int increment_progress = 0;
    public int increment_requirement = 1000;
    public int increment_increase = 500; 

    Rigidbody2D playerObject; 

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        increment_progress = increment_progress + 1;
        if (increment_progress > increment_requirement)
        {
            increment_progress = 0;
            increment_requirement = increment_requirement + increment_increase;

            if (startspeed < maxspeed)
            {
                startspeed = startspeed + incrementspeed;
            }
        }
        playerObject.velocity = new Vector2 (startspeed,0);
    }
}
