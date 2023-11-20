using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomBun : MonoBehaviour
{
    public GameObject bunPrefab;
    private Vector2 screenBounds;
    public int timer = 5;
    public Text Score;


    // Start is called before the first frame update
    void Start()
    {
       screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
       StartCoroutine(createBuns());
        Score.tag = "speed1";
    }

    void spawnBun()
    {
        GameObject a = Instantiate(bunPrefab) as GameObject;   
        a.transform.position = new Vector2(Random.Range(-2, screenBounds.x - 2), Random.Range(-screenBounds.y + 7, screenBounds.y - 7));

        

    }

    // Update is called once per frame
   IEnumerator createBuns()
    {
        while (true)
        {
            Collider[] hitColliders = Physics.OverlapSphere(bunPrefab.transform.position, 200f);
            if (hitColliders.Length == 0)
            {
                spawnBun();
            }
            yield return new WaitForSeconds(timer);
        }
    }

     void Update()
    {
        if (Score.text == "40" && Score.tag == "speed1")
        {
            timer--;
            Score.tag = "speed2";
            
        }

        if (Score.text == "80" && Score.tag == "speed2")
        {
            timer--;
            Score.tag = "speed3";
        }

        if (Score.text == "120" && Score.tag == "speed3")
        {
            timer--;
            Score.tag = "maxSpeed";
            
        }
    }
}
