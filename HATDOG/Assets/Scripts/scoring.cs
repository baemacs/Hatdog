using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public Text Score;
    public int Scoring = 0;

    private void Awake()
    {
        Score.text =  Scoring.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            Scoring += 10;
            Score.text = Scoring.ToString();
        }

    }





}
