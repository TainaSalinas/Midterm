using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTime : MonoBehaviour
{

    public static SelectTime Instance { get; private set; }
    public float BGNumber;
    public float MGNumber;
    public float FGNumber;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



/* void OnMouseDown()
 {
     if (BG)
     {
         BGSelect.SetActive(true);
     }
     else
     {
         BGSelect.SetActive(false);
     }

     if (MG)
     {
         MGSelect.SetActive(true);
     }
     else
     {
         MGSelect.SetActive(false);
     }
 } */
