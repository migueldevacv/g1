using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AsteroidController : MonoBehaviour
{

    public float _asteroidSpeed = 5.0f;
    public bool _directionAssigned = false;
    public float _myX = 0f, myY = 0f;
    public int _type = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_directionAssigned)
        {
            asteroidMovement();
        }
        else
        {
            gameObject.transform.Translate(_myX, myY, 0);
        }
    }
    void asteroidMovement()
    {
        System.Random rX = new System.Random();
        int posX = 0, posY = 0;
        if (transform.position.x < 0f)
            posX = rX.Next(0, 12);
        else
            posX = rX.Next(-11, 1);
        
        System.Random rY = new System.Random();
        if (transform.position.y < 0f)
            posY = rX.Next(0, 8);
        else
            posY = rX.Next(-7, 1);

        _myX = posX * Time.deltaTime;
        myY = posY * Time.deltaTime;
        _directionAssigned = true;
    }

}
