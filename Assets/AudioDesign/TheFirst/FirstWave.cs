using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstWave : MonoBehaviour
{
    public GameObject RAIN;
    public GameObject WIND;
    public GameObject WAVE;
    public GameObject SPACE;
    // Start is called before the first frame update
    void Start()
    {

    }

    

    // Update is called once per frame
    void Update()
    {
        if(RAIN.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 1;
            Debug.Log("One");
        }

        if (WIND.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 2;
            Debug.Log("One");
        }

        if (WAVE.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 3;
            Debug.Log("One");
        }

        if (SPACE.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 4;
            Debug.Log("Four");
        }
    }
}
