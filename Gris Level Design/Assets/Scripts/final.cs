using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour
{
    public GameObject finalScreen;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void SetCanvasActive()
    {
        finalScreen.SetActive(true);
        Invoke("GameOver", 4f);
    }

    private void GameOver()
    {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Invoke("SetCanvasActive", 2f);
        }
    }
}
