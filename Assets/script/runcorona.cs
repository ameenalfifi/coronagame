using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class runcorona : MonoBehaviour

{
    [SerializeField]

    Transform Humen ;   


    [SerializeField]
    float coronaRang = 5f;

    [SerializeField]
    float coronaspeed;

    bool isfacingRight;

    float distencectohumen = Mathf.Infinity;

    Animator anim;

    SpriteRenderer Sr;




    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        Sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         chashumen();

        FlipEnmy();
            
            
            
            }

    void chashumen() {

        distencectohumen = Vector2.Distance(Humen.position, transform.position);

        if (distencectohumen < coronaRang)
        {

            transform.position = Vector2.MoveTowards(transform.position, Humen.position , coronaspeed * Time.deltaTime);

            anim.SetInteger("State", 1);
        
        
        }


       else if (distencectohumen > coronaRang)
        {

            anim.SetInteger("State", 0);


        }

    }



    void FlipEnmy()
    {

        if (Humen.position.x > transform.position.x){

            if (!isfacingRight)
            {

                transform.localScale = new Vector3(transform.localScale.x * -1,
                    transform.localScale.y, transform.localScale.z);

                isfacingRight = true;


            }
        
        }

        else if (Humen.position.x < transform.position.x)
        {

            if (isfacingRight)
            {

                transform.localScale = new Vector3(transform.localScale.x * -1,
                    transform.localScale.y, transform.localScale.z);

                isfacingRight = false;


            }

        }



    }





        private void OnDrawGizmosSelected()
    {

        Gizmos.DrawWireSphere(transform.position, coronaRang);
    
    }
}
