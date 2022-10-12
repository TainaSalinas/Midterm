using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterConfirm : MonoBehaviour
{

    public GameObject body;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        if (ScoreSetUp.Instance.headNumber == 1)
        {
            score = 1;
        }

        if (ScoreSetUp.Instance.torsoNumber == 1)
        {
            score = 2;
        }

        if (ScoreSetUp.Instance.legNumber == 1)
        {
            score = 3;
        }

        if (ScoreSetUp.Instance.footNumber == 2)
        {
            score = 4;
        }
    }

    void OnMouseDown()
    {

        if (score == 4)
        {
            StartCoroutine(TheEnd());
        }
        else
        {
            StartCoroutine(FlashWrong());
        }

      /*  if (ScoreSetUp.Instance.footNumber == 2)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        } else
        {
            StartCoroutine(FlashWrong());
        } */

    }

    IEnumerator TheEnd()
    {
        body.GetComponent<Renderer>().material.color = Color.green;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }

    IEnumerator FlashWrong()
    {
        body.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        body.GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        body.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        body.GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        body.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        body.GetComponent<Renderer>().material.color = Color.white;
    }

}
