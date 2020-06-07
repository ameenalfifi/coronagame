using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerkilled : MonoBehaviour
{
    public AudioClip audioClipKill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag == "Killplayercorona") {
            
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint (audioClipKill, transform.position);
        
        }
    
    
    
    }
}
