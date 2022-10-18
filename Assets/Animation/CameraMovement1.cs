using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement1 : MonoBehaviour
{

    public GameObject cam;
    public GameObject Painting;
    public float score;
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        score = 3;
        Debug.Log("score = 3");
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 3 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("click");
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(40.4f, 0.03f, -0.6589293f), 1);
            Painting.SetActive(true);
            arrow.SetActive(true);

        }
    }
}
