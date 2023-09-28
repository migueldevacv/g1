using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int _life = 100;
    public GameObject _loseScreen;
    public Slider _sliderLife;
    private float _anguloInicial = 90;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per framed
    void Update()
    {
        manageMovement();
        manageLife();
    }

    public float rotationSpeed = 5.0f; // Velocidad de rotación de la nave.

    void manageMovement()
    {
        if (Input.GetKey(KeyCode.S))
            gameObject.transform.Translate(0, -5f * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.W))
            gameObject.transform.Translate(0, 5f * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Translate(-5f * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Translate(5f * Time.deltaTime, 0, 0);

        // Obtén la posición del cursor en el mundo.
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float anguloRadianes = Mathf.Atan2(cursorPosition.y - transform.position.y, cursorPosition.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - _anguloInicial;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }

    void manageLife()
    {
        _sliderLife.value = _life;
    }

    void onDie()
    {
        Time.timeScale = 0;
        _loseScreen.SetActive(true);
    }
}
