using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDelete : MonoBehaviour
{
    public GameObject groundChecker;
    public GameObject me;
    public LayerMask whatIsGround;
    private bool isOnGround;


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collison)
    {
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 5.0f, whatIsGround);

        if (isOnGround == true)
        {
            Destroy(me);
        }

    }
}
