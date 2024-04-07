using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tbuttonscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameManager.trinity = true;
        gameManager.ife = false;
        gameManager.devyn = false;
        gameManager.oak = false;
    }
}
