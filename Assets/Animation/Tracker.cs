using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tracker : MonoBehaviour
{

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject cover;
    public GameObject cover2;
    public static float score;
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;

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
            Arrow1.SetActive(true);
            cover.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.E) && score == 2)
        {
            Arrow2.SetActive(true);
            score = 3;
            cover2.SetActive(true);
        }

        if (score == 4)
        {
            Arrow3.SetActive(true);
            score = 5;
            Text5.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.E) && score == 5)
        {
            score = 6;
            Text5.SetActive(false);
            Text6.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.E) && score == 6)
        {
            TheScreens.Complete = 40;
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
