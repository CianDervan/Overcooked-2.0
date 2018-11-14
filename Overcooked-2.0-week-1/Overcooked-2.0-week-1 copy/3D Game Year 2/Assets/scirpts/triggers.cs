using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class triggers : MonoBehaviour
{

    public bool isImageOn;
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image off;
    public Image off1;
    public Image off2;
    public Image off3;
    public Image off4;
    public Image off5;
    public Image off6;




    public Renderer rend;

    void Start()
    {
        isImageOn = false;
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;
        image4.enabled = false;
        image5.enabled = false;
        image6.enabled = false;
        off.enabled = true;
        off1.enabled = true;
        off2.enabled = true;
        off3.enabled = true;
        off4.enabled = true;
        off5.enabled = true;
        off6.enabled = true;


        rend = GetComponent<Renderer>();
        rend.enabled = false;


    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "image1")
        {
            image1.enabled = true;

            rend.enabled = true;

        }

        if (other.tag == "image2")
        {
            image2.enabled = true;

            
        }

        if (other.tag == "image3")
        {
            image3.enabled = true;

           
        }

        if (other.gameObject.tag == "image4")
        {
            image4.enabled = true;

           
        }

        if (other.tag == "image5")
        {
            image5.enabled = true;

        
        }

        if (other.tag == "image6")
        {
            image6.enabled = true;

            
        }

        if (other.tag == "off")
        {
            off.enabled = false;
        }

        if (other.tag == "off")
        {
            off1.enabled = false;
        }

        if (other.tag == "off")
        {
            off2.enabled = false;
        }

        if (other.tag == "off")
        {
            off3.enabled = false;
        }

        if (other.tag == "off")
        {
            off3.enabled = false;
        }

        if (other.tag == "off")
        {
            off4.enabled = false;
        }

        if (other.tag == "off")
        {
            off5.enabled = false;
        }

        if (other.tag == "off")
        {
            off6.enabled = false;
        }




    }
}
