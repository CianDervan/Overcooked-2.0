using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class sodiumPickup : MonoBehaviour {



    float throwForce = 600;
    Vector3 ObjectPos;
    float Distance;

    public GameObject Sodium;

    public bool isHolding2 = false;

    public AudioSource glass;

    public Text part2;

    public Transform spawnpoint2;

    public GameObject tempParent;

    public GameObject prefab;


    public ParticleEmitter fireworks1;
    public ParticleEmitter fireworks2;

    void Start()
    {
        part2.enabled = false;
        

   
    }



    // Update is called once per frame
    public void Update()
    {


        Vector3.Distance(Sodium.transform.position, tempParent.transform.position);
        if (Distance >= 1f)
        {
            isHolding2 = false;
        }

        if (isHolding2 == true)
        {
            Sodium.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Sodium.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Sodium.transform.SetParent(tempParent.transform);
            Sodium.transform.position = tempParent.transform.position;

        }

        else
        {
            ObjectPos = Sodium.transform.position;
            Sodium.transform.SetParent(null);
            Sodium.GetComponent<Rigidbody>().useGravity = true;
            Sodium.transform.position = ObjectPos;

        }


    }
    void OnMouseDown()
    {

        if (Distance <= 1f)
        {
            isHolding2 = true;
            Sodium.GetComponent<Rigidbody>().useGravity = false;
            Sodium.GetComponent<Rigidbody>().detectCollisions = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "pot")
        {
            part2.enabled = true;



            Destroy(gameObject);

        }

        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            Instantiate(prefab, spawnpoint2.position, transform.rotation);
            glass.Play();
        }

    }

    private void OnMouseUp()
    {
        isHolding2 = false;
    }



}