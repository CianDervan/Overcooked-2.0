using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PickingUp : MonoBehaviour {


    float throwForce = 600;
    Vector3 ObjectPos;
    float Distance;


    public bool canHold = true;
    public GameObject Chemical1;
    public GameObject tempParent;
    public bool isHolding1 = false;
    public Transform spawnpoint;
    public GameObject prefab;
  
    public AudioSource glass;
   
    


    public Image chem1;


    public Text Recipe1;

	// Use this for initialization
	void Start ()
    { 
        chem1.enabled = false;

        Recipe1.enabled = true;
       

    }

    
	
	// Update is called once per frame
	void Update ()
    {

         Vector3.Distance(Chemical1.transform.position, tempParent.transform.position);
        if (Distance >= 1f)
        {
            isHolding1 = false;
        }



        if(isHolding1 == true)
        {

            Chemical1.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Chemical1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Chemical1.transform.SetParent(tempParent.transform);
            Chemical1.transform.position = tempParent.transform.position;

        } else
        {

            ObjectPos = Chemical1.transform.position;
            Chemical1.transform.SetParent(null);
            Chemical1.GetComponent<Rigidbody>().useGravity = true;
            Chemical1.transform.position = ObjectPos;


        }




		
	}


    void OnMouseDown()
    {


        if (Distance <= 1f)
        {
            isHolding1 = true;
            Chemical1.GetComponent<Rigidbody>().useGravity = false;
            Chemical1.GetComponent<Rigidbody>().detectCollisions = true;
        }

    



    }

     void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "pot")
        {
            chem1.enabled = true;
            Destroy(gameObject);
            Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);
        }

        if (other.gameObject.tag == "Ground")
        {
           



            Destroy(gameObject);
            Instantiate(prefab, spawnpoint.position, transform.rotation);
            glass.Play();
        }

    }

    private void OnMouseUp()
    {
            isHolding1 = false;
    }

}
