using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMoving : MonoBehaviour
{

    public float speed = 1.0f;

    Rigidbody2D playerObject; 

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerObject.velocity = new Vector2 (speed,0);
    }
}
