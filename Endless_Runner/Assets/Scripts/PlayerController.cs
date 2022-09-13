using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int runspeed = 1;
    public int sprintspeed = 1;
    public int playerspeed = 1;
    public float jumpforce = 1;
    public int rushtime = 200;
    public int rush = 1;
    bool isOnGround = false;

    public GameObject groundChecker;
    public LayerMask whatIsGround;

    Rigidbody2D playerObject; 

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 
    void Update()
    {
         
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rush = rushtime;
        }

        if (rush > 1)
        {
            playerspeed = sprintspeed;
            rush = rush - 1;
        }

        if (rush == 1)
        {
            playerspeed = runspeed;
        }

        float movementValueX = Input.GetAxis("Horizontal");
        playerObject.velocity = new Vector2 (movementValueX * playerspeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.2f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {

            playerObject.AddForce(new Vector2(0.0f,jumpforce * 100.0f));

        }



    }
}
