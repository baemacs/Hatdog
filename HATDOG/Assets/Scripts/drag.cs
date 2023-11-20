using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{

    public GameObject cubePrefab;
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    public float throwForce = 10.5f;
    Vector3 originalPos,size;
    Quaternion rotation;
    bool checker = false ;


   void Awake()
    {
        originalPos = cubePrefab.transform.position;
         size = cubePrefab.transform.localScale;
        rotation = cubePrefab.transform.rotation;

        GetComponent <CameraAnchor> ().enabled = false;



    }

    void Update()
    {
        //if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        GetComponent<Rigidbody2D>().mass = 2f;
        if (Input.GetMouseButtonDown(0) && !checker && Time.timeScale >= 1f)
        {

            touchTimeStart = Time.time;
            startPos = Input.mousePosition;

        }

        //if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        else if(Input.GetMouseButtonUp(0) && !checker && Time.timeScale >= 1f)
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            GetComponent<Rigidbody2D>().IsAwake();
            touchTimeFinish = Time.time;
            timeInterval = (touchTimeFinish - touchTimeStart);
            endPos = Input.mousePosition;
            direction = startPos + endPos;
            
            GetComponent<Rigidbody2D>().AddForce(direction / timeInterval * throwForce);
            GetComponent<Rigidbody2D>().AddTorque(-30, ForceMode2D.Force);

            checker = true;
           
        }

       

   


        
    }

     void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag != "healing")
        {
            cubePrefab.transform.position = originalPos;
            cubePrefab.transform.localScale = size;
            cubePrefab.transform.rotation = rotation;
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<Rigidbody2D>().Sleep();
            checker = false;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        Invoke("checking", 0.5f);



        

    }


    public void checking()
    {
        cubePrefab.transform.position = originalPos;
        cubePrefab.transform.localScale = size;
        cubePrefab.transform.rotation = rotation;
        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<Rigidbody2D>().Sleep();
        checker = false;

    }


}
