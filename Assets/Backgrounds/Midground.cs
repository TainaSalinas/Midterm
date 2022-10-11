using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Midground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseDown()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
