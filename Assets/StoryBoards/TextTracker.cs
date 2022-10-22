using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextTracker : MonoBehaviour
{

    public static float score;
    public static float score2;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;
    public GameObject SB;
    public GameObject cover1;
    public GameObject cover2;
    public GameObject cover3;

    public AudioSource Text;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && score == 0)
        {
            this.GetComponent<AudioSource>().Play();
            Text2.SetActive(true);
            score = 1;
            Text1.SetActive(false);
            SB.SetActive(false);
            cover1.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && score == 1)
        {
            this.GetComponent<AudioSource>().Play();
            Text3.SetActive(true);
            score = 2;
            Arrow1.SetActive(true);
            cover2.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.E) && score == 2)
        {
            this.GetComponent<AudioSource>().Play();
            Text4.SetActive(true);
            score = 3;
            Arrow2.SetActive(true);
            Arrow3.SetActive(true);
            cover3.SetActive(true);
            Debug.Log("score3");
        }

        else if (Input.GetKeyDown(KeyCode.E) && score == 4)
        {
            this.GetComponent<AudioSource>().Play();
            Text6.SetActive(true);
            score = 5;
            Text5.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.E) && score == 5)
        {
            this.GetComponent<AudioSource>().Play();
            TheScreens.Complete = 20;
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
