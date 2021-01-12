using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyes : MonoBehaviour
{
    public GameObject[] triggerPlatforms;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            for (int i = 0; i < triggerPlatforms.Length; i++)
            {
                triggerPlatforms[i].GetComponent<Collider2D>().isTrigger = true;
            }
        }
    }
}
