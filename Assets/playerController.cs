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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
