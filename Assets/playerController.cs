using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float hForce = 4;
    public float vForce = 4;

    public KeyCode upKey = KeyCode.W;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode downKey = KeyCode.S;
    public KeyCode rightKey = KeyCode.D;

    public GameObject Interact;
    public GameObject Interact1;
    public bool pos1;
    public bool pos2;
    public GameObject Ntext;
    public GameObject Ntext1;
    public GameObject Jtext;
    public GameObject Jtext1;
    public GameObject Jtext2;
    public float score;
    public float score1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "NateText")
        {
            Interact.SetActive(true);
            pos1 = true;
        }

        if (collision.gameObject.name == "JoshText")
        {
            Interact1.SetActive(true);
            pos2 = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "NateText")
        {
            Interact.SetActive(false);
            pos1 = false;
            Ntext.SetActive(false);
            Ntext1.SetActive(false);
            score = 0;
        }

        if (collision.gameObject.name == "JoshText")
        {
            Interact1.SetActive(false);
            pos2 = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        ///~~~Movement~~~///

        Vector3 pos = transform.position;

        if (Input.GetKey(upKey))
        {
            pos.y += vForce * Time.deltaTime;
        }

        if (Input.GetKey(downKey))
        {
            pos.y -= vForce * Time.deltaTime;
        }

        if (Input.GetKey(rightKey))
        {
            pos.x += hForce * Time.deltaTime;
        }

        if (Input.GetKey(leftKey))
        {
            pos.x -= hForce * Time.deltaTime;
        }

        transform.position = pos;

        ///~~~Interacting With Blue NPCS~~~///

        if (pos1 == true && Input.GetKeyDown(KeyCode.E))
        {
            Ntext.SetActive(true);
            score++;
        }

       else if (pos1 == true && score == 1 && Input.GetKeyDown(KeyCode.E))
        {
            Ntext1.SetActive(true);
            Ntext.SetActive(false);
        }

        if (pos2 == true && Input.GetKeyDown(KeyCode.E))
        {
            Jtext.SetActive(true);
            score1 = 1;
        }

        else if (pos2 == true && score == 1 && Input.GetKeyDown(KeyCode.E))
        {
            Jtext1.SetActive(true);
            score1 = 2;
            Jtext.SetActive(false);
        }

        else if (pos2 == true && score == 2 && Input.GetKeyDown(KeyCode.E))
        {
            Jtext2.SetActive(true);
            Jtext1.SetActive(false);
        }
    }
}

   
