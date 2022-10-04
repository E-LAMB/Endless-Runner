using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimates : MonoBehaviour
{

    public int playerspeed = 0;
    public GameObject stopChecker;
    public LayerMask whatIsStop;
    bool mustStop;

    Rigidbody2D playerObject; 

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mustStop = Physics2D.OverlapCircle(stopChecker.transform.position, 0.2f, whatIsStop);

        if (mustStop == false)
        {
            playerObject.velocity = new Vector2 (playerspeed,0);
        }
    }
}
