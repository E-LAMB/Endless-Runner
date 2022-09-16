using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleDetector : MonoBehaviour
{

    public GameObject peopleChecker;
    public LayerMask whatIsDeath;

    static int points;
    static int maxium;

    Rigidbody2D currentObject;

    public bool isDead = false;
    public bool isScored = false;

    // Start is called before the first frame update
    void Start()
    {
        currentObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        maxium += 1
        
        if (isDead == false)
        {

        isDead = Physics2D.OverlapCircle(peopleChecker.transform.position, 1.5f, whatIsDeath);

        }

        if (isDead == true && isScored == false)
        {
            currentObject.AddForce(new Vector2(0.0f,33.0f));
            isScored = true;
            points += 1;
        }

    }
}
