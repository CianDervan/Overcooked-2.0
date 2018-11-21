using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour {


    float throwForce = 600;
    Vector3 ObjectPos;
    float Distance;


    public bool canHold = true;
    public GameObject Chemical1;
    public GameObject tempParent;
    public bool isHolding = false; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

         Vector3.Distance(Chemical1.transform.position, tempParent.transform.position);
        if (Distance >= 1f){
            isHolding = false;
        }



        if(isHolding == true){

            Chemical1.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Chemical1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Chemical1.transform.SetParent(tempParent.transform);

        } else {

            ObjectPos = Chemical1.transform.position;
            Chemical1.transform.SetParent(null);
            Chemical1.GetComponent<Rigidbody>().useGravity = true;
            Chemical1.transform.position = ObjectPos;


        }




		
	}


     void FixedUpdate()
    {

        if(Input.GetKeyDown(KeyCode.E)){
            if (Distance <= 1f)
            {
                isHolding = true;
                Chemical1.GetComponent<Rigidbody>().useGravity = false;
                Chemical1.GetComponent<Rigidbody>().detectCollisions = true;
            }

        } if(Input.GetKeyUp(KeyCode.E)){

            isHolding = false;

        }

    }



}
