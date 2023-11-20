using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class triggerCode : MonoBehaviour
{
    public GameObject Bun;
    public float timer;
    public GameObject poof;


    void Start()
    {
        timer = 0;
        Bun.tag = "enemy";
        Console.WriteLine("Nice");
    }

    void Update()
    {
        Console.WriteLine("HIt!");
        timer += Time.deltaTime;

        if(timer > 5)
        {
            Bun.tag = "damage";
            

        }

        if (timer >= 5.05f)
        {
            
            timer = 0;
            Destroy(Bun);
        }
       
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        Destroy(Bun);
        Instantiate(poof, transform.position, Quaternion.identity);
    }

}

