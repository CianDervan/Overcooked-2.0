using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chemical1 : MonoBehaviour {
    public GameObject Chemical_1;
    public GameObject tempParent;
    public Transform guide;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {

        Chemical_1.GetComponent<Rigidbody>().useGravity = false;
        Chemical_1.GetComponent<Rigidbody>().isKinematic = true;
        Chemical_1.transform.position = guide.transform.position;
        Chemical_1.transform.rotation = guide.transform.rotation;
        Chemical_1.transform.parent = tempParent.transform;



    }
}
