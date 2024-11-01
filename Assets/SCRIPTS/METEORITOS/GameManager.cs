using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int meteorito;
    public TextMeshProUGUI contadorMeteoritosText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    private void Start()
    {
        ContadorUI();
    }

    public void IncrementarContador()
    {
        meteorito++;
        ContadorUI();
    }

    private void ContadorUI()
    {
        if (contadorMeteoritosText != null)
        {
            contadorMeteoritosText.text = "" + meteorito;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        contadorMeteoritosText = GameObject.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        meteorito = 0;
        ContadorUI();
    }
}
