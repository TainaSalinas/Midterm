using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFilm : MonoBehaviour
{

    public AudioSource End;
    public AudioClip FilmReel;
    public AudioClip Text;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Film;
    public float number;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        End = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player_front")
        {
            number = 1;
            End.PlayOneShot(FilmReel, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (number == 1)
        {
            Text1.SetActive(true);
            number = 2;
        }

        else if (Input.GetKeyDown(KeyCode.E) && number == 2)
        {
            Text2.SetActive(true);
            number = 3;
            Text1.SetActive(false);
            End.PlayOneShot(Text, 1f);
        }

        else if (Input.GetKeyDown(KeyCode.E) && number == 3)
        {
            Text3.SetActive(true);
            number = 4;
            Text2.SetActive(false);
            End.PlayOneShot(Text, 1f);

        }

        else if (Input.GetKeyDown(KeyCode.E) && number == 4)
        {
            Text4.SetActive(true);
            number = 5;
            Text3.SetActive(false);
            End.PlayOneShot(Text, 1f);

        }

        else if (Input.GetKeyDown(KeyCode.E) && number == 5)
        {
            Text5.SetActive(true);
            number = 6;
            Text4.SetActive(false);
            End.PlayOneShot(Text, 1f);

        }

        else if (Input.GetKeyDown(KeyCode.E) && number == 6)
        {
            Text6.SetActive(true);
            number = 7;
            Text5.SetActive(false);
            End.PlayOneShot(Text, 1f);

        }

        else if (Input.GetKeyDown(KeyCode.E) && number == 7)
        {
            End.PlayOneShot(Text, 1f);
            SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
        }
    }
}
