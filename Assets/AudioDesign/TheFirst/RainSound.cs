using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSound : MonoBehaviour
{

    public AudioSource mySpace;
    bool isClicked = false;
    public GameObject SPACE;
    public GameObject RAIN;
    public bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnMouseEnter()
    {
        if (isClicked == false)
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
    }

    void OnMouseDown()
    {
        if (!isClicked)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            isClicked = true;
            selected = true;
            this.GetComponent<AudioSource>().Play();
            GameManager.Instance.assignedNumber = 1;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
            this.GetComponent<AudioSource>().Play();
            isClicked = false;
            selected = false;
            GameManager.Instance.assignedNumber = 0;
        }
    }


    void OnMouseExit()
    {
        if (isClicked == false)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /* GetComponent<Renderer>().material.color = Color.blue;
     if (GetComponent<Renderer>().material.color == Color.blue)
     {
         isClicked = true;
     } */
}
