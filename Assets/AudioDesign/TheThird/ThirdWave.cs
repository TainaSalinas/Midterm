using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdWave : MonoBehaviour
{

    public GameObject ANIMAL;
    public GameObject BIKE;
    public GameObject CAR;
    public GameObject FOOTSTEP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ANIMAL.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 12;
        }

        if (BIKE.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 11;
        }

        if (CAR.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 10;
        }

        if (FOOTSTEP.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 9;
        }
    }
}
