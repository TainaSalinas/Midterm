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
        GetComponent<Renderer>().material.color = Color.white;

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
        StartCoroutine(Flash());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Flash()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        yield return new WaitForSeconds(0.3f);
        GetComponent<Renderer>().material.color = Color.clear;
    }
}
