using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleepCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.ife == true || gameManager.oak == true || gameManager.devyn == true || gameManager.trinity == true)
            gameObject.SetActive(false);
    }
}
