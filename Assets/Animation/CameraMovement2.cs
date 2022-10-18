using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2 : MonoBehaviour
{

    public GameObject cam;
    public GameObject Painting;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 4;
        Debug.Log("score = 4");
    }

    void Update()
    {
        if (score == 4 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(64f, 0.03f, -0.6589293f), 1);
            Painting.SetActive(false);

        }
    }

}
