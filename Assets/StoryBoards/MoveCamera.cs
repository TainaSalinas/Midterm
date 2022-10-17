using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public GameObject cam;
    public float clicks;
    public GameObject Painting;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TextTracker.score == 2 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.GetComponent<Renderer>().material.color = Color.red;
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(20.3f, 0.03f, -0.6589293f), 1);
           
        }
        else if (TextTracker.score == 3 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(40.4f, 0.03f, -0.6589293f), 1);
            Painting.SetActive(true);
            
        }
        else if (TextTracker.score == 4 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(64, 0.03f, -0.6589293f), 1);
            Painting.SetActive(false);
        }

        if(clicks == 3)
        {
            //Painting.SetActive(true);
        }
    }

    void OnMouseDown()
    {
       /* if (clicks == 0)
        {
            cam.GetComponent<Renderer>().material.color = Color.red;
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(43, 0.03f, -0.6589293f), 0.5f);
            clicks = 1;
        }
        else if (clicks == 1)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(80, 0.03f, -0.6589293f), 0.5f);
            clicks = 2;        
        }
        else if (clicks == 2)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(45, 0.03f, -0.6589293f), 0.5f);
            clicks = 3;
        } */
    }
}
