using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfirmButton : MonoBehaviour
{

public GameObject rain;
public GameObject wind;
public GameObject wave;
public GameObject space;
public GameObject footstep;
public GameObject animals;
public GameObject bicycle;
public GameObject car; 
public GameObject door;
public GameObject subway;
public GameObject cabinet;
public GameObject trapdoor;
    public GameObject SecWave;
    public GameObject ThiWave;

    public AudioSource Sound;
    public AudioClip Confirm;
    public AudioClip Wrong;

    // Start is called before the first frame update
    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if(GameManager.Instance.assignedNumber == 1)
        {
            StartCoroutine(TheSecondWave());
        }

        if (GameManager.Instance.assignedNumber == 2)
        {
            StartCoroutine(FlashWrong());
        }

        if (GameManager.Instance.assignedNumber == 3)
        {
            StartCoroutine(FlashWrong());
        }

        if (GameManager.Instance.assignedNumber == 4)
        {
           StartCoroutine(FlashWrong());
        }

        ///////////////////////////////////////

        if (GameManager.Instance.assignedNumber == 5)
        {
            StartCoroutine(TheThirdWave());
        }

        if (GameManager.Instance.assignedNumber == 6)
        {
            StartCoroutine(FlashWrong());
        }

        if (GameManager.Instance.assignedNumber == 7)
        {
            StartCoroutine(FlashWrong());
        }

        if (GameManager.Instance.assignedNumber == 8)
        {
            StartCoroutine(FlashWrong());
        }

        ///////////////////////////////////////

        if (GameManager.Instance.assignedNumber == 9)
        {
            StartCoroutine(TheEnd());
        }

        if (GameManager.Instance.assignedNumber == 10)
        {
            StartCoroutine(FlashWrong());
        }

        if (GameManager.Instance.assignedNumber == 11)
        {
            StartCoroutine(FlashWrong());
        }

        if (GameManager.Instance.assignedNumber == 12)
        {
            StartCoroutine(FlashWrong());
        }
    }

    
        

    IEnumerator FlashWrong()
    {
        Sound.PlayOneShot(Wrong, 1f);
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

    IEnumerator TheSecondWave()
    {
        Sound.PlayOneShot(Confirm, 1f);
        rain.GetComponent<Renderer>().material.color = Color.green;
        wind.GetComponent<Renderer>().material.color = Color.red;
        wave.GetComponent<Renderer>().material.color = Color.red;
        space.GetComponent<Renderer>().material.color = Color.red;
        ThiWave.SetActive(true);
        yield return new WaitForSeconds(1);
        rain.SetActive(false);
        wind.SetActive(false);
        wave.SetActive(false);
        space.SetActive(false);
        AudioTracker.score = 3;
    }

    IEnumerator TheThirdWave()
    {
        Sound.PlayOneShot(Confirm, 1f);
        door.GetComponent<Renderer>().material.color = Color.green;
        subway.GetComponent<Renderer>().material.color = Color.red;
        cabinet.GetComponent<Renderer>().material.color = Color.red;
        trapdoor.GetComponent<Renderer>().material.color = Color.red;
        SecWave.SetActive(true);
        yield return new WaitForSeconds(1);
        door.SetActive(false);
        subway.SetActive(false);
        cabinet.SetActive(false);
        trapdoor.SetActive(false);
        AudioTracker.score = 4;
    }

    IEnumerator TheEnd()
    {
        Sound.PlayOneShot(Confirm, 1f);
        footstep.GetComponent<Renderer>().material.color = Color.green;
        animals.GetComponent<Renderer>().material.color = Color.red;
        bicycle.GetComponent<Renderer>().material.color = Color.red;
        car.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(1);
        TheScreens.Complete = 50;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
