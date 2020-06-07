using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    public AudioClip audioClipKill;
    public string levelName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "AstroStay1") {

            Destroy(other.gameObject);
            Application.LoadLevel(levelName);
            AudioSource.PlayClipAtPoint(audioClipKill, transform.position);



        }
    }
}
