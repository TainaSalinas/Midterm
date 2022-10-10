using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSound : MonoBehaviour
{
    public AudioSource mySpace;
    bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseEnter()
    {
        if(isClicked == false)
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
    }

    void OnMouseDown()
    {
       /* GetComponent<Renderer>().material.color = Color.blue;
        if (GetComponent<Renderer>().material.color == Color.blue)
        {
            isClicked = true;
        } */


        if (!isClicked)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            isClicked = true;
            this.GetComponent<AudioSource>().Play();
            GameManager.Instance.assignedNumber = 4;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
            isClicked = false;
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
        
        if(GetComponent<Renderer>().material.color == Color.red)
        {
            isClicked = false;
        }
    }
}
