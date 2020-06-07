using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;


public class potionRotite : MonoBehaviour
{

    public AudioClip soundpotion;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("AstroStay1") )
        {
            
                AudioSource.PlayClipAtPoint(soundpotion, other.transform.position);

            
        }

        

    }
}
