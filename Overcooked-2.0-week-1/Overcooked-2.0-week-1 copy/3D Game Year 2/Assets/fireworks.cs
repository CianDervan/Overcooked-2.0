using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireworks : MonoBehaviour {
    public Transform firework;
    public AudioSource sound;


    // Use this for initialization
    void Start () {

        firework.GetComponent<ParticleSystem>().enableEmission = false;


	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void  OnTriggerEnter (Collider col){

        if(col.gameObject.tag == "pickable"){
            firework.GetComponent<ParticleSystem>().enableEmission = true;
        }



    }


}
