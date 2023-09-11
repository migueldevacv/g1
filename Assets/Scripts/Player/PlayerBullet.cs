using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            PlayerController controller = player.GetComponent<PlayerController>();
            if (controller != null)
            {
                // Debug.Log($"Son las balas del player en bullet {controller.actualBullets}");
            }
        }
        gameObject.transform.Translate(0, -25f * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemies")
        {
            Debug.Log("mataste al enemigo");
            GameObject.Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        GameObject.Destroy(gameObject);
    }
}
