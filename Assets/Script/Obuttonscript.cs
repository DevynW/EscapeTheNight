using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obuttonscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
            
     }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void MyFunct()
    {
        gameManager.oak = true;
        gameManager.devyn = false;
        gameManager.ife = false;
        gameManager.trinity = false;
    }

}
