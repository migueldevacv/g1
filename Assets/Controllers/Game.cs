using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject[] _asteroidList;
    public float _asteroidGenTime = 8.0f;
    public float _lastAsteroidGen = 0f;

    public GameObject[] _enemyList;
    public float _enemyGenTime = 100.0f;
    public float _lastEnemyGen = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_lastAsteroidGen >= _asteroidGenTime)
        {
            _lastAsteroidGen = 0f;
            asteroidGen();
        }
        _lastAsteroidGen += Time.deltaTime;
    }

    void asteroidGen()
    {
        System.Random random = new System.Random();
        int randomGen = random.Next(0, _asteroidList.Length);
        GameObject asteroid = GameObject.Instantiate(_asteroidList[randomGen]);
        // asteroid.transform.parent = transform;
        calculatePosition(asteroid);

    }

    void calculatePosition(GameObject spawnedObject)
    {
        System.Random random1 = new System.Random();
        int randomGen1 = random1.Next(0, 2);

        System.Random random2 = new System.Random();
        int randomGen2 = random1.Next(0, 2);

        if (randomGen1 == 0) // si aparece en eje y
        {
            System.Random rX = new System.Random();
            int posX = rX.Next(-11, 12);
            if (randomGen1 == 0) // si aparece arriba
                spawnedObject.transform.position = new Vector3(posX, 7f);
            else // si aparece abajo
                spawnedObject.transform.position = new Vector3(posX,- 7f);
        }
        else // si aparece en eje x
        {

            System.Random rX = new System.Random();
            int posX = rX.Next(-11, 12);
            System.Random rY = new System.Random();
            int posY = rY.Next(-7, 7);
            if (randomGen1 == 0) // si aparece en la derecha
                spawnedObject.transform.position = new Vector3(11, posY);
            else // si aparece en la izq
                spawnedObject.transform.position = new Vector3(-11, posY);

        }
    }
}
