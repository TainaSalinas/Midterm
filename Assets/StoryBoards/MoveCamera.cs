using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        cam.GetComponent<Renderer>().material.color = Color.red;
        cam.transform.position = new Vector3(15, -0.7954547f, -0.6589293f);
    }
}
