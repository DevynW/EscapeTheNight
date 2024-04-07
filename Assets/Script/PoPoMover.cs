using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoPoMover : MonoBehaviour
{
    [SerializeField] int speed = 3;
    [SerializeField] int direction;
    [SerializeField] int endZ;
    [SerializeField] int endX;
    [SerializeField] bool z = true;
    [SerializeField] bool pos = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z >= endZ && z == true && pos == true)
        {
            gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, -1 * endZ);
        }
        if (gameObject.transform.position.z <= endZ && z == true && pos == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -1 * endZ);
        }
        if (gameObject.transform.position.x >= endX && z == false && pos == true)
        {
            gameObject.transform.position = new Vector3(-1 * endX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x <= endX && z == false && pos == false)
        {
            gameObject.transform.position = new Vector3(-1 * endX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        gameObject.transform.Translate(speed * Time.deltaTime * Vector3.forward, Space.Self);

    }
}
