using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerAnimate : MonoBehaviour
{
    public GameObject Interact;
    public GameObject TryAgain;
    public bool pos;
    public bool neg = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front" && TheScreens.Complete == 30)
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
            SceneManager.LoadScene("Animation", LoadSceneMode.Single);
        }

        else if (neg == true && Input.GetKeyDown(KeyCode.E))
        {
            TryAgain.SetActive(true);
        }
    }
}
