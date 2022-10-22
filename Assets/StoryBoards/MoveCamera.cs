using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public AudioSource Page;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (TextTracker.score == 2 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.GetComponent<Renderer>().material.color = Color.red;
            this.GetComponent<AudioSource>().Play();
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(20.3f, 0.03f, -0.6589293f), 1);
           
        }
     /*   else if (TextTracker.score == 3 && Input.GetKeyDown(KeyCode.Mouse0))
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
        } */
    }
}
