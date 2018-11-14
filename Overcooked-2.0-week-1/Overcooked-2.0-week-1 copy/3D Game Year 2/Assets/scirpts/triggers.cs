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

    void Start()
    {
        isImageOn = false;
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;
        image4.enabled = false;
        image5.enabled = false;
        image6.enabled = false;

    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "image1")
        {
            image1.enabled = true;
        }

        if (other.tag == "image2")
        {
            isImageOn = true;
        }

        if (other.tag == "image3")
        {
            isImageOn = true;
        }

        if (other.gameObject.tag  == "image4")
        {
            isImageOn = true;
        }

        if (other.tag == "image5")
        {
            isImageOn = true;
        }

        if (other.tag == "image6")
        {
            isImageOn = true;
        }

    }

}
