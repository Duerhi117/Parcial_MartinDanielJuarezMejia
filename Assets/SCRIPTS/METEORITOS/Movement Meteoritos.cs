using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementMeteoritos : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0, 0, -5 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioManager.AudioInstance.Play("Explosion");
            AudioManager.AudioInstance.Play("Fin");
            Destroy(gameObject);
            Destroy(other.gameObject);
            SceneManager.LoadScene("Juego");
        }

        if (other.gameObject.CompareTag("Bala"))
        {
            AudioManager.AudioInstance.Play("Impacto");
            GameManager.Instance.IncrementarContador();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
