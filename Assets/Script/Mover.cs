using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject cam;
    //Animator animator;
    Vector3 checkpoint;
    Vector3 beginning;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        checkpoint = new Vector3 (0f, 1.04f, 0f);
        beginning = new Vector3(0f, 1.04f, -49f);

        if(Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Time.deltaTime * speed * Vector3.forward);
            //animator.SetBool("forward", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Time.deltaTime * speed * -1f * Vector3.forward); 
            //animator.SetBool("back", true);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Time.deltaTime * speed * Vector3.right);
            //animator.SetBool("right", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Time.deltaTime * speed * -1f * Vector3.right);
            //animator.SetBool("left", true);
        }
        cam.transform.position = new Vector3(gameObject.transform.position.x, cam.transform.position.y, gameObject.transform.position.z - 3f);
        if (Input.GetKeyDown(KeyCode.Space) == true && gameManager.devyn == true)
        {
            //pepperspray here
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && gameManager.ife == true)
        {
            //runn here
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && gameManager.oak == true)
        {
            //duckk n dodge here
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && gameManager.trinity == true)
        {
            //flashlight here
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MorehouseMan") == true)
        {
            Debug.Log("Ooh, he gotcha didn't he?!");

            if (gameObject.transform.position.z >= 0f)
            {
                gameObject.transform.position = checkpoint;
            }
            else
            {
                gameObject.transform.position = beginning;
            }
        }
        if (other.gameObject.CompareTag("PoPoLice") == true)
        {
            gameObject.transform.position = beginning;
            gameManager.deathCount += 1;
        }
        
    }
}
