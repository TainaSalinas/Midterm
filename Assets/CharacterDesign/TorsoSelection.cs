using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorsoSelection : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public bool selected = false;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void OnMouseEnter()
    {

    }

    void OnMouseExit()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine(Flash());
        selected = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (selected == true)
        {
            if (Input.GetKeyDown(KeyCode.D) && score == 0)
            {
                one.SetActive(true);
                score = 1;
                ScoreSetUp.Instance.torsoNumber = 1;
            }

            else if (Input.GetKeyDown(KeyCode.D) && score == 1)
            {
                one.SetActive(false);
                two.SetActive(true);
                score = 2;
            }
            else if (Input.GetKeyDown(KeyCode.D) && score == 2)
            {
                two.SetActive(false);
                three.SetActive(true);
                score = 3;
            }

            else if (Input.GetKeyDown(KeyCode.D) && score == 3)
            {
                three.SetActive(false);
                four.SetActive(true);
                score = 4;
            }

            else if (Input.GetKeyDown(KeyCode.D) && score == 4)
            {
                four.SetActive(false);
                five.SetActive(true);
                score = 5;
            }
            else if (Input.GetKeyDown(KeyCode.D) && score == 5)
            {
                five.SetActive(false);
                score = 0;
            }

         

            /*  if (Input.GetKeyDown(KeyCode.D) && score == 2)
              {
                  Debug.Log("Third Outfit");
                  two.SetActive(false);
                  three.SetActive(true);
              }

              if (Input.GetKeyUp(KeyCode.D) && score == 2)
              {
                  score = 3;
              }

              if (Input.GetKeyDown(KeyCode.D) && score == 3)
              {
                  Debug.Log("Fourth");
                  three.SetActive(false);
                  four.SetActive(true);
              }

              if (Input.GetKeyUp(KeyCode.D) && score == 3)
              {
                  score = 4;
              }

              if (Input.GetKeyDown(KeyCode.D) && score == 4)
              {
                  Debug.Log("Fifth");
                  four.SetActive(false);
                  five.SetActive(true);
              }

              if (Input.GetKeyUp(KeyCode.D) && score == 4)
              {
                  score = 5;
              } */
        }
    }

    IEnumerator Flash()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        yield return new WaitForSeconds(0.3f);
        GetComponent<Renderer>().material.color = Color.white;
    }
}
