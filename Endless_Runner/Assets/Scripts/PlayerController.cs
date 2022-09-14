using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int normalspeed = 1;
    public float jumpforce = 1;
    bool isOnGround = false;

    public bool inrush = false;
    public int rushspeed = 1;
    public int rushcooldown = 0;
    public int maxrushcooldown = 100; // The cooldown of a rush
    public int rushregenerate = 1; // The speed at which a rush regenerates
    public int rushheat = 0; // How long until the player is forced out of a rush
    public int rushheatlimit = 100; // The upper limit to a player's heat
    public float rushlevitation = 0.0f; // The vertical distance a rush gets

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
        if (Input.GetKeyDown(KeyCode.LeftShift) && rushcooldown == 0)
        {
            inrush = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && inrush == true)
        {
            inrush = false;
            rushcooldown = maxrushcooldown;
            rushheat = 0;
        }

        if (rushcooldown > 0)
        {
            rushcooldown = rushcooldown - rushregenerate;
        }
        if (rushheat > rushheatlimit)
        {
            inrush = false;
            rushheat = 0;
            rushcooldown = maxrushcooldown * 2;
        }

        if (inrush == true)
        {
            playerspeed = rushspeed;
            rushheat = rushheat + 1;
            float movementValueX = Input.GetAxis("Horizontal");
            playerObject.velocity = new Vector2 (playerspeed,rushlevitation);
        }   
        if (inrush == false)
        {
            playerspeed = normalspeed;
            float movementValueX = Input.GetAxis("Horizontal");
            playerObject.velocity = new Vector2 (movementValueX * playerspeed, playerObject.velocity.y);
        }

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.2f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {

            playerObject.AddForce(new Vector2(0.0f,jumpforce * 100.0f));

        }



    }
}