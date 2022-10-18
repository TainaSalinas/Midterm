using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement1 : MonoBehaviour
{

    public GameObject cam;
    public GameObject Painting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (Tracker.score == 3 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(40.4f, 0.03f, -0.6589293f), 1);
            Painting.SetActive(true);

        }
    }
}
