using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject prefab;
    private float fireRate = 0.75f;
    private float lastShoot = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per framed
    void Update()
    {
        manageMovement();
        manageShoots();
    }
    void manageMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(0, 5f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(0, -5f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(-5f * Time.deltaTime, 0, 0);
        }
    }
    private void manageShoots()
    {
        lastShoot += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && (lastShoot >= fireRate))
        {
            GameObject newBullet = GameObject.Instantiate(prefab);
            newBullet.gameObject.SetActive(true);
            newBullet.transform.position = transform.position;
            lastShoot = 0f;
            //            Debug.Log($"Bullets {actualBullets}");
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
