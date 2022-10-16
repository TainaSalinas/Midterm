using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSound : MonoBehaviour
{

    public AudioSource mySpace;
    public GameObject SPACE;
    public GameObject RAIN;
    public GameObject WIND;
    public GameObject WAVE;
    bool isClicked = false;

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
        RAIN.SetActive(false);
        SPACE.SetActive(false);
        WIND.SetActive(true);
        WAVE.SetActive(false);
    }

    void OnMouseExit()
    {
            GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
