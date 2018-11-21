using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    private Inventory inventory;


	// Use this for initialization
	void Start () {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            for (int i = 0; i < inventory.slots.length; i++)
            {
                if(inventory.isFull[i] == false){

                    inventory.isFull[i] = true;
                    break;

                }

            }

        }
    }
}
