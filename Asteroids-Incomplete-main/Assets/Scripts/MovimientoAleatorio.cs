using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    float horizontal;
    float vertical;
    float movement_rotation;
    float fuerza;


    void Start()
    {
        horizontal = Random.Range(-1f, 1f);
        if (horizontal < 0f) horizontal = -1f;
        else horizontal = 1f;
        vertical = Random.Range(-1f, 1f);

        fuerza = Random.Range(-1f, 5f);

        movement_rotation = Random.Range(0, 180);

        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -horizontal * movement_rotation);

    }

    void Update()
    {

        Vector3 direccion = new Vector3(horizontal, vertical).normalized;

        transform.position += direccion * (speed * fuerza) * Time.deltaTime;

    }
}
