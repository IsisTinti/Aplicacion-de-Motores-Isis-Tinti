using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject CarryPosition;
    public GameObject _pickedObject=null;

    private  void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer==3)
        {

            if (Input.GetKey("e") && _pickedObject == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = CarryPosition.transform.position;
                other.gameObject.transform.SetParent(CarryPosition.gameObject.transform);
                _pickedObject = other.gameObject;
             //   GetComponent<PlatformInteraction>().food.SetActive (true);
            }          
        }
  }
    private void Update()
    {if(_pickedObject != null)
        if (Input.GetKey("q"))
        {
            _pickedObject.GetComponent<Rigidbody>().useGravity = true;
            _pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                _pickedObject.gameObject.transform.SetParent(null);
                _pickedObject=null;
           //     GetComponent<PlatformInteraction>().food.SetActive(false);
            }
    }

}
