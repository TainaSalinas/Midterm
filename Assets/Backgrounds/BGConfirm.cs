using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGConfirm : MonoBehaviour
{

    public float score = 0;
    public float score1 = 0;
    public float score2 = 0;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public float number;

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
        number = 0;
        Confirm = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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

        if (SelectTime.Instance.BGNumber == 3)
        {
            score = 1;
        } else {
            score = 0;
        }

        if (SelectTime.Instance.MGNumber == 1)
        {
            score1 = 1;
        } else {
            score1 = 0;
        }

        if (SelectTime.Instance.FGNumber == 2)
        {
            score2 = 1;
        } else {
            score2 = 0;
        }
    }

   void OnMouseDown()
   {

        if (score == 1 && score1 == 1 && score2 == 1)
        {
           StartCoroutine(TheEnd());
        }
        else
        {
           StartCoroutine(FlashWrong());
        }
   }

    IEnumerator TheEnd()
    {
        Confirm.PlayOneShot(Correct, 1f);
        GetComponent<Renderer>().material.color = Color.green;
        yield return new WaitForSeconds(1);
        TheScreens.Complete = 30;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }

    IEnumerator FlashWrong()
    {
        Confirm.PlayOneShot(Wrong, 1f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.white;
    }
}
