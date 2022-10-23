using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2 : MonoBehaviour
{

    public GameObject cam;
    public AudioSource Page;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnMouseDown()
    {
        if (Tracker.score == 4 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.GetComponent<AudioSource>().Play();
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(64f, 0.03f, -0.6589293f), 1);
        }
    }

}
