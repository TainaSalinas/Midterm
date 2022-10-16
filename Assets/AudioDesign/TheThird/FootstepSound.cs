using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource mySpace;
    bool isClicked = false;
    public GameObject ANIMAL;
    public GameObject BIKE;
    public GameObject CAR;
    public GameObject FOOTSTEP;

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
        ANIMAL.SetActive(false);
        BIKE.SetActive(false);
        CAR.SetActive(false);
        FOOTSTEP.SetActive(true);
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

        if (GetComponent<Renderer>().material.color == Color.white)
        {
            isClicked = false;
        }
    }

    /* GetComponent<Renderer>().material.color = Color.blue;
        if (GetComponent<Renderer>().material.color == Color.blue)
        {
            isClicked = true;
        } */
}
