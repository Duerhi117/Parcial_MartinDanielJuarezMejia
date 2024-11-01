using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;

    public float limiteMinX = -5f;
    public float limiteMaxX = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float movimientoX = HorizontalMove() * velocidad;

        float rangoPosicionX = Mathf.Clamp(transform.position.x + movimientoX, limiteMinX, limiteMaxX);

        rb.velocity = transform.rotation * new Vector3(rangoPosicionX - transform.position.x, 0, 0);
    }

    public float HorizontalMove()
    {
        return Input.GetAxis("Horizontal");
    }
}
