using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class scriptpotion : MonoBehaviour
{

    public int potionvalue = 1;

    public PotionManger gamemedicinetext;



    // Start is called before the first frame update
    void Start()
    {
        gamemedicinetext = FindObjectOfType<PotionManger>();
    }



    private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.CompareTag("AstroStay1")) {

            gamemedicinetext.Changepotuon(potionvalue);
            Destroy(gameObject);



        }


    }
}
