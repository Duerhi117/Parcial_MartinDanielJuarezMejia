using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform bala;
    public Transform puntoDisparo;
    private bool puedeDisparar = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && puedeDisparar)
        {
            StartCoroutine(Disparar());
        }
    }

    private IEnumerator Disparar()
    {
        puedeDisparar = false;
        AudioManager.AudioInstance.Play("Disparo");
        Instantiate(bala, puntoDisparo.position, puntoDisparo.rotation);
        yield return new WaitForSeconds(1);
        puedeDisparar = true;
    }
}
