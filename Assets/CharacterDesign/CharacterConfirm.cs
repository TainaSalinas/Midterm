using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterConfirm : MonoBehaviour
{

    public GameObject body;
    public float score = 0;
    public float score1 = 0;
    public float score2 = 0;
    public float score3 = 0;
    public float number;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;

    public AudioSource Confirm;
    public AudioClip Correct;
    public AudioClip Wrong;
    public AudioClip Text;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        score1 = 0;
        score2 = 0;
        score3 = 0;
        number = 0;
        Confirm = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && number == 0)
        {
            Confirm.PlayOneShot(Text, 1f);
            Text2.SetActive(true);
            number = 1;
            Text1.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && number == 1)
        {
            Confirm.PlayOneShot(Text, 1f);
            Text3.SetActive(true);
            number = 2;
            Text2.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && number == 2)
        {
            Confirm.PlayOneShot(Text, 1f);
            Text4.SetActive(true);
            number = 3;
            Text3.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && number == 3)
        {
            Confirm.PlayOneShot(Text, 1f);
            Text5.SetActive(true);
            number = 4;
            Text4.SetActive(false);
        }

        if (ScoreSetUp.Instance.headNumber == 3)
        {
            score = 1;
            Debug.Log("one");
        } else
        {
            score = 0;
        }

        if (ScoreSetUp.Instance.torsoNumber == 4)
        {
            score1 = 1;
            Debug.Log("two");
        }
        else
        {
            score1 = 0;
        }

        if (ScoreSetUp.Instance.legNumber == 2)
        {
            Debug.Log("three");
            score2 = 1;
        }
        else
        {
            score2 = 0;
        }

        if (ScoreSetUp.Instance.footNumber == 2)
        {
            Debug.Log("four");
            score3 = 1;
        }
        else
        {
            score3 = 0;
        }
    }

    void OnMouseDown()
    {

        if (score == 1 && score1 == 1 && score2 == 1 && score3 == 1)
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
        Confirm.PlayOneShot(Correct, 1f);
        body.GetComponent<Renderer>().material.color = Color.green;
        yield return new WaitForSeconds(1);
        TheScreens.Complete = 10;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }

    IEnumerator FlashWrong()
    {
        Confirm.PlayOneShot(Wrong, 1f);
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
