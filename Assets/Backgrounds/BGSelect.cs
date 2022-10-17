using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSelect : MonoBehaviour
{

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SelectTime.Instance.BGNumber = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && score == 0)
        {
            one.SetActive(true);
            score = 1;
            SelectTime.Instance.BGNumber = 1;

        }

        else if (Input.GetKeyDown(KeyCode.Space) && score == 1)
        {
            one.SetActive(false);
            two.SetActive(true);
            score = 2;
            SelectTime.Instance.BGNumber = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && score == 2)
        {
            two.SetActive(false);
            three.SetActive(true);
            score = 3;
            SelectTime.Instance.BGNumber = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && score == 3)
        {
            three.SetActive(false);
            score = 0;
            SelectTime.Instance.BGNumber = 0;
        }
    }
}
