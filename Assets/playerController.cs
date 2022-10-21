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

   /* public GameObject Interact;
    public GameObject Interact1;
    public bool pos1;
    public bool pos2;
    public GameObject Ntext;
    public GameObject Ntext1;
    public GameObject Jtext;
    public GameObject Jtext1;
    public GameObject Jtext2;
    public float score;
    public float score1; */

    //Animations and States
    Animator animator;
    string currentState;
    const string Player_Down = "PlayerAnimation";
    const string Player_Left = "PlayerAnimLeft";
    const string Player_Right = "PlayerAnimRight";
    const string Player_Up = "PlayerAnimUp";
    const string Player_Idle_Up = "PlayerIdleUp";
    const string Player_Idle_Down = "PlayerIdleDown";
    const string Player_Idle_Left = "PlayerIdleLeft";
    const string Player_Idle_Right = "PlayerIdleRight";

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void ChangeAnimationState(string newState)
    {
        //stop animation from interrupting self
        if (currentState == newState) return;

        //play new
        animator.Play(newState);

        //Update state
        currentState = newState;
    }

   

    // Update is called once per frame
    void Update()
    {

        ///~~~Movement~~~///

        Vector3 pos = transform.position;

        if (Input.GetKey(upKey))
        {
            pos.y += vForce * Time.deltaTime;
            ChangeAnimationState(Player_Up);
        }
        if (currentState == Player_Up && !Input.GetKey(upKey))
        {
            ChangeAnimationState(Player_Idle_Up);
        }

        if (Input.GetKey(downKey))
        {
            pos.y -= vForce * Time.deltaTime;
            ChangeAnimationState(Player_Down);
        }
        if(currentState == Player_Down && !Input.GetKey(downKey))
        {
            ChangeAnimationState(Player_Idle_Down);
        }

        if (Input.GetKey(rightKey))
        {
            pos.x += hForce * Time.deltaTime;
            ChangeAnimationState(Player_Right);
        }
        if (currentState == Player_Right && !Input.GetKey(rightKey))
        {
            ChangeAnimationState(Player_Idle_Right);
        }

        if (Input.GetKey(leftKey))
        {
            pos.x -= hForce * Time.deltaTime;
            ChangeAnimationState(Player_Left);
        }
        if (currentState == Player_Left && !Input.GetKey(leftKey))
        {
            ChangeAnimationState(Player_Idle_Left);
        }

        transform.position = pos;

        
    }

    /* void OnTriggerEnter2D(Collider2D collision)
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
    } */

    ///~~~Interacting With Blue NPCS~~~/// --- Update

    /* if (pos1 == true && Input.GetKeyDown(KeyCode.E))
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
     } */
}


