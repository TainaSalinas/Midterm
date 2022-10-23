using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBG : MonoBehaviour
{

    public GameObject Interact;
    public GameObject TryAgain;
    public bool pos;
    public bool neg = false;

    public AudioSource Select;
    public AudioClip CantAccess;
    public AudioClip Okay;

    // Start is called before the first frame update
    void Start()
    {
        Select = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front" && TheScreens.Complete == 20)
        {
            Interact.SetActive(true);
            pos = true;
        }
        else
        {
            Interact.SetActive(true);
            neg = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front")
        {
            Interact.SetActive(false);
            pos = false;
            TryAgain.SetActive(false);
            neg = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pos == true && Input.GetKeyDown(KeyCode.E))
        {
            Select.PlayOneShot(Okay, 1f);
            SceneManager.LoadScene("Backgrounds", LoadSceneMode.Single);
        }
        else if (neg == true && Input.GetKeyDown(KeyCode.E))
        {
            Select.PlayOneShot(CantAccess, 1f);
            TryAgain.SetActive(true);
        }
    }
}
