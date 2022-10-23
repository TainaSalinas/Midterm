using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject cam;
    public AudioSource Page;

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
        if (Tracker.score == 2 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.GetComponent<AudioSource>().Play();
            cam.GetComponent<Renderer>().material.color = Color.red;
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(20.3f, 0.03f, -0.6589293f), 1);

        }
    }
}
