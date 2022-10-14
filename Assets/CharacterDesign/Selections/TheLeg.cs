using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheLeg : MonoBehaviour
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
        LegOutfits.SetActive(true);
        TorsoOutfits.SetActive(false);
        HeadOutfits.SetActive(false);
        FootOutfits.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
