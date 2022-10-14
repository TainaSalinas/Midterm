using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{

    public GameObject BGSelect;
    public GameObject MGSelect;
    public GameObject FGSelect;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.clear;
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.blue;

    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.clear;
    }

    void OnMouseDown()
    {
        BGSelect.SetActive(true);
        MGSelect.SetActive(false);
        FGSelect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
