using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTime : MonoBehaviour
{

    public GameObject BG;
    public GameObject MG;
    public GameObject FG;
    public GameObject BGSelect;
    public GameObject MGSelect;
    public GameObject FGSelect;

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.name);
            }
        }
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
