using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody player;
    private float movespeed = 30f;
    private float turnSpeed = 100f;
    void Start()
    {
        player = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up*turnSpeed*Input.GetAxis("Horizontal")*Time.deltaTime);
       transform.Translate(0f,0f,movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
