using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yes : MonoBehaviour

{
    public string gotopage;

    public void Goto() {

        SceneManager.LoadScene(gotopage);


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
