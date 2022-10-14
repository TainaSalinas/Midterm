using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroText : MonoBehaviour
{

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject player;
    public GameObject FirstCamera;
    public float number = 0;



    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && number == 0)
        {
            Text2.SetActive(true);
            Text1.SetActive(false);
            number = 1;
        }

        else if (Input.GetKeyDown(KeyCode.Space) && number == 1)
        {
            Text3.SetActive(true);
            Text2.SetActive(false);
            number = 2;
        }

        else if (Input.GetKeyDown(KeyCode.Space) && number == 2)
        {
            Text4.SetActive(true);
            Text3.SetActive(false);
            number = 3;
        }

        else if (Input.GetKeyDown(KeyCode.Space) && number == 3)
        {
            Text4.SetActive(false);
            number = 4;
            player.SetActive(true);
            FirstCamera.SetActive(false);
        }
    }
}
