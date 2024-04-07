using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static int deathCount = 0;
    public static bool oak = false;
    public static bool devyn = false;
    public static bool ife = false;
    public static bool trinity = false;
    [SerializeField] GameObject gameOver;
    
    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(deathCount >= 3)
        {
            gameOver.SetActive(true);
        }
        

        if (gameManager.ife == true && i == 1)
        {
            Debug.Log("it's I");
            i++;
        }
        if (gameManager.oak == true && i == 1)
        {
            Debug.Log("it's O");
            i++;
        }
        if ( gameManager.devyn == true && i == 1)
        {
            Debug.Log("it's D");
            i++;
        }
        if (gameManager.trinity == true && i == 1)
        {
            Debug.Log("it's T");
            i++;
        }
    }

   
}
