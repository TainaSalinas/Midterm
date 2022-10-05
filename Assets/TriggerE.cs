using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerE : MonoBehaviour
{

    public GameObject Interact;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front")
        {
            Interact.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front")
        {
            Interact.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
