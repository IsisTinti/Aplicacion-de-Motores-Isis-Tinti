using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformInteraction : MonoBehaviour
{ 
    public GameObject food;
    public GameObject Platform;
    private int points;

    private void start()
    {
        points = 0;
        //    food.SetActive(true);
      //  food = _pickedObject;
    }
    void OnTriggerEnter(Collider other)
    {

        if (food.tag == Platform.tag)
        {
           // food.SetActive(false);
            points ++;
         
            

        } 
        Debug.Log(points);
        Destroy(food.gameObject);
    }

   
   
}
