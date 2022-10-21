using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement3 : MonoBehaviour
{

    public GameObject cam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(84f, 0.03f, -0.6589293f), 1);
        }
    }
}
