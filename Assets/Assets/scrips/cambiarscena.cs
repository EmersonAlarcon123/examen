using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarscena : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag ==("Player"))
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Victoria");
    }
}
