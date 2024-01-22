using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.PlayerSettings;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    private bool entered = false;
    private float interval;
    private bool enable = false;
    public GameObject floor;
    void Start()
    { 
        interval = Random.Range(4.0f, 5.0f);
        Destroy(gameObject,interval);
        Debug.Log(transform.position+" : "+interval);
    }
    public void SetVariable()
    {
        entered = true;
    }
    public bool getVariable()
    {
        return entered;
    }

    // Update is called once per frame
    void Update()
    {   
        if(interval>1.5)
        { interval -= Time.deltaTime; }
        else if(!enable)
        { 
            int x = Random.Range(0, 4);
            switch (x)
            {
                case 0:
                    Instantiate(floor, transform.position + new Vector3(9, 0, 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(floor, transform.position + new Vector3(-9, 0, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(floor, transform.position + new Vector3(0, 0, 9), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(floor, transform.position + new Vector3(0, 0, -9), Quaternion.identity);
                    break;
            }
            enable = true;
        }
     
    }

}
