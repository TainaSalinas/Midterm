using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTracker : MonoBehaviour
{

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public static float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && score == 0)
        {
            Text2.SetActive(true);
            score = 1;
            Text1.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.E) && score == 1)
        {
            Text3.SetActive(true);
            score = 2;
            Text2.SetActive(false);
        }

        if(score == 3)
        {
            Text4.SetActive(true);
            Text3.SetActive(false);
        }

        if (score == 4)
        {
            Text5.SetActive(true);
            Text4.SetActive(false);
        }
    }
}
