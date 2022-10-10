using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSetUp : MonoBehaviour
{

    public static ScoreSetUp Instance { get; private set; }
    public float headNumber;
    public float torsoNumber;
    public float legNumber;
    public float footNumber;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
