using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement4 : MonoBehaviour
{

    public GameObject cam;
    public GameObject Painting;
    public AudioSource Page;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.GetComponent<AudioSource>().Play();
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(104f, 0.03f, -0.6589293f), 1);
            Painting.SetActive(false);
        }
    }

    
}
