using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    public float waitingStartTime;
    public float timer;

    private bool startDone;
    private float time;

    void Start()
    {
        Invoke("startTree", waitingStartTime);
    }

    void Update()
    {
        if (startDone)
        {
            time += Time.deltaTime;
            if (time <= timer)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            else if (time >= timer && time < timer * 2)
            {
                transform.GetChild(0).gameObject.SetActive(false);
            }
            else time = 0;
        }
    }

    private void startTree()
    {
        startDone = true;
    }
}
