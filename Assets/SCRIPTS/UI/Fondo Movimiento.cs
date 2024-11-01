using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FondoMovimiento : MonoBehaviour
{
    public RawImage fondo;
    public float movY;

    private void Update()
    {
        fondo.uvRect = new Rect(fondo.uvRect.position + new Vector2(0, movY) * Time.deltaTime, fondo.uvRect.size);
    }
}
