using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFoot : MonoBehaviour
{

    public GameObject HeadOutfits;
    public GameObject TorsoOutfits;
    public GameObject LegOutfits;
    public GameObject FootOutfits;
    public GameObject HeadArrow;
    public GameObject TorsoArrow;
    public GameObject LegArrow;
    public GameObject FootArrow;

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
        FootArrow.SetActive(true);
        TorsoOutfits.SetActive(false);
        LegOutfits.SetActive(false);
        HeadOutfits.SetActive(false);
        TorsoArrow.SetActive(false);
        LegArrow.SetActive(false);
        HeadArrow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
