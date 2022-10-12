using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBG : MonoBehaviour
{

    public GameObject Interact;
    public bool pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front")
        {
            Interact.SetActive(true);
            pos = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front")
        {
            Interact.SetActive(false);
            pos = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pos == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Backgrounds", LoadSceneMode.Single);
        }
    }
}
