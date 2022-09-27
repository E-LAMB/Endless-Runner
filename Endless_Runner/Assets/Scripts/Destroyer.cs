using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collison)
    {
        
        if (collison.gameObject.tag == "Clean")
        {
            Destroy(collison.gameObject);
        }

    }
}
