using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomHealth : MonoBehaviour
{

    public int healthRandomizer = 0;
    public GameObject heartPrefab;
    private Vector2 screenBounds;
    public float timer;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        timer = 0;


    }

     void Update()
    {
        timer += Time.deltaTime;

        



        healthRandomizer = Random.Range(4000, 0);
       

        if (healthRandomizer == 135 || healthRandomizer == 69 && Time.timeScale != 0f ) 
        {
            GameObject a = Instantiate(heartPrefab) as GameObject;
            a.transform.position = new Vector2(Random.Range(-2, screenBounds.x - 2), Random.Range(-screenBounds.y + 7, screenBounds.y - 7));
           
           
        }
    }

    
}
