using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSound : MonoBehaviour
{

    public AudioSource mySpace;
    bool isClicked = false;
    public GameObject SPACE;
    public GameObject RAIN;
    public GameObject WIND;
    public GameObject WAVE;

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
            RAIN.SetActive(true);
            SPACE.SetActive(false);
            WIND.SetActive(false);
            WAVE.SetActive(false);
            /*GetComponent<Renderer>().material.color = Color.yellow;
            isClicked = true;
            selected = true;
            this.GetComponent<AudioSource>().Play();
            GameManager.Instance.assignedNumber = 1;
            */
           // GetComponent<Renderer>().material.color = Color.white;
           // this.GetComponent<AudioSource>().Play();
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
