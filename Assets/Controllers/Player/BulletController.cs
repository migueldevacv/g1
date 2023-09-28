using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Vector3 _newPosition;
    public float _damage;
    public float _speed = 10;

    private void Start()
    {

        // _newPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        GameObject.Destroy(gameObject);
    }
}
