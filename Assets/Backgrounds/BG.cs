using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{

    public GameObject MG;
    public GameObject FG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        MG.SetActive(false);
        FG.SetActive(false);

    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
        MG.SetActive(true);
        FG.SetActive(true);
    }

    void OnMouseDown()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
