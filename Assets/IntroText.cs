using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroText : MonoBehaviour
{

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject player;
    public GameObject FirstCamera;
    public float number = 0;
    public GameObject Cintique1;
    public GameObject Cintique2;
    public GameObject Cintique3;
    public GameObject Cintique4;
    public GameObject Cintique5;
    public GameObject CharacterTrigger;
    public GameObject StoryboardTrigger;
    public GameObject BackgroundTrigger;
    public GameObject AnimateTrigger;
    public GameObject AudioTrigger;
    public GameObject Final;



    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (TheScreens.Complete == 0)
        {
            if (Input.GetKeyDown(KeyCode.E) && number == 0)
            {
                Text2.SetActive(true);
                Text1.SetActive(false);
                number = 1;
            }

            else if (Input.GetKeyDown(KeyCode.E) && number == 1)
            {
                Text3.SetActive(true);
                Text2.SetActive(false);
                number = 2;
            }

            else if (Input.GetKeyDown(KeyCode.E) && number == 2)
            {
                Text4.SetActive(true);
                Text3.SetActive(false);
                number = 3;
            }

            else if (Input.GetKeyDown(KeyCode.E) && number == 3)
            {
                Text4.SetActive(false);
                number = 4;
                player.SetActive(true);
                FirstCamera.SetActive(false);
            }
        } 
        else
        {
            Text1.SetActive(false);
            FirstCamera.SetActive(false);
            player.SetActive(true);
        }

        if(TheScreens.Complete == 10)
        {
            Cintique1.SetActive(false);
            CharacterTrigger.SetActive(false);
        }

        if (TheScreens.Complete == 20)
        {
            Cintique2.SetActive(false);
            StoryboardTrigger.SetActive(false);
        }
        if (TheScreens.Complete == 30)
        {
            Cintique3.SetActive(false);
            BackgroundTrigger.SetActive(false);
        }

        if (TheScreens.Complete == 40)
        {
            Cintique4.SetActive(false);
            AnimateTrigger.SetActive(false);
        }

        if (TheScreens.Complete == 50)
        {
            Cintique5.SetActive(false);
            AudioTrigger.SetActive(false);
            Final.SetActive(true);
        }
    }
}
