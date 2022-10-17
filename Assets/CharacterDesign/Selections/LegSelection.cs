using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegSelection : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreSetUp.Instance.legNumber = 0;
        score = 0;
    }

    void OnMouseDown()
    {
        StartCoroutine(Flash());
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space) && score == 0)
            {
                one.SetActive(true);
                score = 1;
                ScoreSetUp.Instance.legNumber = 1;
            }

            else if (Input.GetKeyDown(KeyCode.Space) && score == 1)
            {
                one.SetActive(false);
                two.SetActive(true);
                score = 2;
                ScoreSetUp.Instance.legNumber = 2;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && score == 2)
            {
                two.SetActive(false);
                three.SetActive(true);
                score = 3;
                ScoreSetUp.Instance.legNumber = 3;
            }

            else if (Input.GetKeyDown(KeyCode.Space) && score == 3)
            {
                three.SetActive(false);
                four.SetActive(true);
                score = 4;
                ScoreSetUp.Instance.legNumber = 4;
            }

            else if (Input.GetKeyDown(KeyCode.Space) && score == 4)
            {
                four.SetActive(false);
                score = 0;
                ScoreSetUp.Instance.legNumber = 0;
            }
    }

    IEnumerator Flash()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        yield return new WaitForSeconds(0.3f);
        GetComponent<Renderer>().material.color = Color.clear;
    }
}
