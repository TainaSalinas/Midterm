using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFoot : MonoBehaviour
{

    public GameObject HeadOutfits;
    public GameObject TorsoOutfits;
    public GameObject LegOutfits;
    public GameObject FootOutfits;

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
        FootOutfits.SetActive(true);
        TorsoOutfits.SetActive(false);
        LegOutfits.SetActive(false);
        HeadOutfits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
