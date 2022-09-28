using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Catchup

    public int normalspeed = 1;
    public float jumpforce = 1;
    bool isOnGround = false;
    int playerspeed = 0;
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
        playerspeed = normalspeed;
        float movementValueX = Input.GetAxis("Horizontal");
        playerObject.velocity = new Vector2 (movementValueX*playerspeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f,jumpforce * 100.0f));
        }

    }
}
