using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetSound : MonoBehaviour
{
    public AudioSource mySpace;
    bool isClicked = false;
    public GameObject TRAPDOOR;
    public GameObject CABINET;
    public GameObject SUBWAY;
    public GameObject CARDOOR;

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
        TRAPDOOR.SetActive(false);
        CABINET.SetActive(true);
        CARDOOR.SetActive(false);
        SUBWAY.SetActive(false);


    }

    void OnMouseExit()
    {
            GetComponent<Renderer>().material.color = Color.white;
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
