using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstWave : MonoBehaviour
{
    public GameObject RAIN;
    public GameObject WIND;
    public GameObject WAVE;
    public GameObject SPACE;
    bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        RAIN = GameObject.Find("rain");
        WIND = GameObject.Find("windy");
        WAVE = GameObject.Find("wave");
        SPACE = GameObject.Find("space");
    }

    void OnMouseEnter()
    {
        if (isClicked == false)
        {
            RAIN.GetComponent<Renderer>().material.color = Color.yellow;
            WIND.GetComponent<Renderer>().material.color = Color.yellow;
            WAVE.GetComponent<Renderer>().material.color = Color.yellow;
            SPACE.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    void OnMouseDown()
    {

        if (!isClicked)
        {
           
            GetComponent<Renderer>().material.color = Color.yellow;
            isClicked = true;
            this.GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
            this.GetComponent<AudioSource>().Play();
            isClicked = false;
            
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
}
