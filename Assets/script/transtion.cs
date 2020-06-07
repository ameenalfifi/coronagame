using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transtion : MonoBehaviour
{

    public string levelname;
    private bool mode = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !mode) {

            mode = true;
            Application.LoadLevel(levelname);
        }
    }
}
