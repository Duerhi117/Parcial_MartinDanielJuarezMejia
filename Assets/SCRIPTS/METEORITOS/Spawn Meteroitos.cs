using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteoritos : MonoBehaviour
{
    public GameObject meteorito;
    public float rangoX;
    public float rangoZ;
    public float intervaloGeneracion = 1f;
    private void Start()
    {
        StartCoroutine(GenerarMeteoritos());
    }

    private IEnumerator GenerarMeteoritos()
    {
        while (true) 
        {
            Vector3 posicionAleatoria = new Vector3( Random.Range(-rangoX, rangoX), transform.position.y, Random.Range(7, rangoZ));
            
            GameObject nuevoObjeto = Instantiate(meteorito, posicionAleatoria, Quaternion.identity);
            
            Destroy(nuevoObjeto, 6f);
            
            yield return new WaitForSeconds(intervaloGeneracion);
        }
    }
}
