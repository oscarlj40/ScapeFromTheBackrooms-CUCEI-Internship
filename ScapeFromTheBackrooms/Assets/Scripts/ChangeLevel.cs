using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{

    public string nombreEscena = "Level_1";

    bool change;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            change = true;

        }

    }

    void Update()
    {
        if (change)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Iniciando nivel 1");
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                SceneManager.LoadScene(nombreEscena);
            }
        }
    }

}
