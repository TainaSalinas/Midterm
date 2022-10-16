using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondWave : MonoBehaviour
{

    public GameObject CABINET;
    public GameObject SUBWAY;
    public GameObject CARDOOR;
    public GameObject TRAPDOOR; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CARDOOR.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 5;
        }

        if (CABINET.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 6;
        }

        if (SUBWAY.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 7;
        }

        if (TRAPDOOR.activeInHierarchy == true)
        {
            GameManager.Instance.assignedNumber = 8;
        }
    }
}
