using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterPick : MonoBehaviour {


    float throwForce = 600;
    Vector3 ObjectPos;
    float Distance;

    public GameObject Water;

    public bool isHolding3 = false;

    public AudioSource glass;

    public Image water;

    public Transform spawnpoint2;

    public GameObject tempParent;

    public GameObject prefab;

    public Text Step2;

    public Text Step1;


    void Start(){
        water.enabled = false;
        Step2.enabled = false;
    }



    // Update is called once per frame
    public void Update () {


        Vector3.Distance(Water.transform.position, tempParent.transform.position);
        if (Distance >= 1f)
        {
            isHolding3 = false;
        }

        if (isHolding3 == true)
        {
            Water.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Water.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Water.transform.SetParent(tempParent.transform);
            Water.transform.position = tempParent.transform.position;

        }

        else
        {
            ObjectPos = Water.transform.position;
            Water.transform.SetParent(null);
            Water.GetComponent<Rigidbody>().useGravity = true;
            Water.transform.position = ObjectPos;

        }


    }
    void OnMouseDown()
    {

        if (Distance <= 1f)
        {
            isHolding3 = true;
            Water.GetComponent<Rigidbody>().useGravity = false;
            Water.GetComponent<Rigidbody>().detectCollisions = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "pot")
        {
            water.enabled = true;
            Step2.enabled = true;
            Step1.enabled = false;
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
        isHolding3 = false;
    }

}
