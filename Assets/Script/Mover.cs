using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed;
    Animator animator;
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
        checkpoint = new Vector3 (0f, 0f, 0f);
        beginning = new Vector3(0f, 0f, 49f);

        if(Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Time.deltaTime * speed * Vector3.forward);
            //animator.SetBool("forward", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(Time.deltaTime * speed * -1f * Vector3.forward); 
            animator.SetBool("back", true);

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

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MorehouseMan") == true)
        {
            Debug.Log("Ooh, he gotcha didn't he?!");

            gameObject.transform.position = checkpoint;

        }
        if (other.gameObject.CompareTag("PoPoLice") == true);
        {
            gameObject.transform.position = beginning;
        }
    }
}
