using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public GameObject cam;
    public float clicks;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Painting;

    // Start is called before the first frame update
    void Start()
    {
        clicks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (clicks == 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.GetComponent<Renderer>().material.color = Color.red;
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(20.3f, 0.03f, -0.6589293f), 1);
            clicks = 1;
        }
        else if (clicks == 1 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(40.4f, 0.03f, -0.6589293f), 1);
            clicks = 2;
        }
        else if (clicks == 2 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(64, 0.03f, -0.6589293f), 1);
            clicks = 3;
        }

        if(clicks == 3)
        {
            Painting.SetActive(true);
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
