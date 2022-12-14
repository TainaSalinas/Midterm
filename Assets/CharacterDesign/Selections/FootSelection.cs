using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSelection : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreSetUp.Instance.footNumber = 0;
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
                ScoreSetUp.Instance.footNumber = 1;
            }

            else if (Input.GetKeyDown(KeyCode.Space) && score == 1)
            {
                one.SetActive(false);
                two.SetActive(true);
                score = 2;
                ScoreSetUp.Instance.footNumber = 2;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && score == 2)
            {
                two.SetActive(false);
                three.SetActive(true);
                score = 3;
                ScoreSetUp.Instance.footNumber = 3;
            }

            else if (Input.GetKeyDown(KeyCode.Space) && score == 3)
            {
                three.SetActive(false);
                score = 0;
                ScoreSetUp.Instance.footNumber = 0;
            }
    }

    IEnumerator Flash()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        yield return new WaitForSeconds(0.3f);
        GetComponent<Renderer>().material.color = Color.clear;
    }
}
