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
    [SerializeField] GameObject winner;

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
        

        if (gameManager.ife == true)
        {
            Debug.Log("it's I");
        }
        if (gameManager.oak == true)
        {
            Debug.Log("it's O");
        }
        if ( gameManager.devyn == true)
        {
            Debug.Log("it's D");
        }
        if (gameManager.trinity == true)
        {
            Debug.Log("it's T");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finishLine") == true && deathCount < 3)
        {
            winner.SetActive(true);
        }
    }
}
