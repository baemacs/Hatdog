using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healing : MonoBehaviour
{
    public GameObject healingObject;
    public float timer;

     void Start()
    {
        timer = 0;   
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(healingObject);
    }


    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 4)
        {
            Destroy(healingObject);

        }


    }
}
