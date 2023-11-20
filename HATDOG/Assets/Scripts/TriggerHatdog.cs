using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHatdog : MonoBehaviour
{
    public GameObject hatdog;
    Vector3 originalPos;

    void Start()
    {
        originalPos = new Vector3(hatdog.transform.position.x, hatdog.transform.position.y, hatdog.transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        hatdog.transform.position = originalPos;

    }


}
