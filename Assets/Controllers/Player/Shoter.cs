using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoter : MonoBehaviour
{
    public Transform shoterController;
    public GameObject[] _bulletTypes;

    public float _fireRateNormal = 0.5f;
    public float _lastShotNormal = 0f;
    public float _fireRateSpecial = 2f;
    public float _lastShotSpecial = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1))
            manageShot();

        _lastShotNormal += Time.deltaTime;
        _lastShotSpecial += Time.deltaTime;
    }

    void manageShot()
    {
        if (_lastShotNormal >= _fireRateNormal && Input.GetKey(KeyCode.Mouse0))
        {
            GameObject.Instantiate(_bulletTypes[0], shoterController.position, shoterController.rotation);
            _lastShotNormal = 0f;
        }
        else if (_lastShotSpecial >= _fireRateSpecial && Input.GetKey(KeyCode.Mouse1))
        {       
            GameObject.Instantiate(_bulletTypes[1], shoterController.position, shoterController.rotation);
            _lastShotSpecial = 0f;
        }

    }
}
