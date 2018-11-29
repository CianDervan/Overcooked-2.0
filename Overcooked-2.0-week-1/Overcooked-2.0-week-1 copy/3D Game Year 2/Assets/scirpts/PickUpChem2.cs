using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpChem2 : MonoBehaviour {


    float throwForce = 600;
    Vector3 ObjectPos;
    float Distance;

    public GameObject Chemical2;

    public bool isHolding2 = false;

    public AudioSource glass;

    public Image chem2;

    public Transform spawnpoint2;

    public GameObject tempParent;

    public GameObject prefab;


    void Start(){
        chem2.enabled = false;
    }



    // Update is called once per frame
    public void Update () {


        Vector3.Distance(Chemical2.transform.position, tempParent.transform.position);
        if (Distance >= 1f)
        {
            isHolding2 = false;
        }

        if (isHolding2 == true)
        {
            Chemical2.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Chemical2.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Chemical2.transform.SetParent(tempParent.transform);
            Chemical2.transform.position = tempParent.transform.position;

        }

        else
        {
            ObjectPos = Chemical2.transform.position;
            Chemical2.transform.SetParent(null);
            Chemical2.GetComponent<Rigidbody>().useGravity = true;
            Chemical2.transform.position = ObjectPos;

        }


    }
    void OnMouseDown()
    {

        if (Distance <= 1f)
        {
            isHolding2 = true;
            Chemical2.GetComponent<Rigidbody>().useGravity = false;
            Chemical2.GetComponent<Rigidbody>().detectCollisions = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "pot")
        {
            chem2.enabled = true;
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