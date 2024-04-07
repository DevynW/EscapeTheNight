using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleepInstructions : MonoBehaviour
{
    [SerializeField] GameObject instructions;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameManager.ife == true || gameManager.oak == true || gameManager.devyn == true || gameManager.trinity == true && i == 1)
        {
            instructions.SetActive(true);
        }

        Destroy(instructions, 10f);
    }
}
