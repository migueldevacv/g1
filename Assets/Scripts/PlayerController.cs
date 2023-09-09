using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int points = 0; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        manageMovement();
    }

    void manageMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "barrier")
        {
            Debug.Log("Chocaste");
        }
    }
}
