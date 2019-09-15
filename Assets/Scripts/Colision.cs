using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Targets")
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "UpLevel")
        {
            Application.LoadLevel(2);
        }
        if (collision.gameObject.tag == "UpLevell")
        {
            Application.LoadLevel(3);
        }

    }
}
