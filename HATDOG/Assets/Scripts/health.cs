using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    //public Text healthBar;
    public int healthScore =100;
    public GameObject heart1, heart2, heart3, heart4, heart5;
    public Vector3 heartPos1, heartPos2, heartPos3, heartPos4, heartPos5;


    void Awake()
    {
        //healthBar.text = "Health: " + healthScore + "%";
    }

     void Start()
    {
        StartCoroutine(HealthScore());
        heartPos1 = heart1.transform.localScale;
        heartPos2 = heart2.transform.localScale;
        heartPos3 = heart3.transform.localScale;
        heartPos4 = heart4.transform.localScale;
        heartPos5 = heart5.transform.localScale;
    }




    void HealthyLiving()             
    {
        if (GameObject.FindGameObjectWithTag("damage"))
        {
            healthScore -= 20;
        }

       // healthBar.text = "Health: " + healthScore + "%";

        if (healthScore == 80)
        {
            heart1.transform.localScale = new Vector3(0, 0, 0);
            heart1.tag = "destroyed";

        }
     
        if (healthScore == 60)
        {
            heart2.transform.localScale = new Vector3(0, 0, 0);
            heart2.tag = "destroyed";

        }
       
        if (healthScore == 40)
        {
            heart3.transform.localScale = new Vector3(0, 0, 0);
            heart3.tag = "destroyed";

        }
       
        if (healthScore == 20)
        {
            heart4.transform.localScale = new Vector3(0, 0, 0);
            heart4.tag = "destroyed";

        }


        if (healthScore == 0)
        {
            heart5.transform.localScale = new Vector3(0, 0, 0);
            FindObjectOfType<gameManager>().GameOver();

        }
    }

    IEnumerator HealthScore()
    {
        while (true)
        {
            HealthyLiving();
            yield return new WaitForSeconds(0.05f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "healing")
        {
            if(heart1.tag == "destroyed" && heart2.tag == "destroyed" && heart3.tag == "destroyed" && heart4.tag == "destroyed")
            {
                heart4.transform.localScale = heartPos4;
                heart4.tag = "fourthHealth";
                healthScore += 20;
            }

            else if(heart1.tag == "destroyed" && heart2.tag == "destroyed" && heart3.tag == "destroyed")
            {
                heart3.transform.localScale = heartPos3;
                heart3.tag = "thirdHealth";
                healthScore += 20;
            }

            else if(heart1.tag == "destroyed" && heart2.tag == "destroyed")
            {
                heart2.transform.localScale = heartPos2;
                heart2.tag = "secHealth";
                healthScore += 20;
            }

            else if (heart1.tag == "destroyed")
            {
                heart1.transform.localScale = heartPos1;
                heart1.tag = "firstHealth";
                healthScore += 20;
            }

        } 
    }

}
