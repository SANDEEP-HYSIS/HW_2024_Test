using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject floor;
    void Start()
    {
       Instantiate(floor,new Vector3(0,0,0), Quaternion.identity);
    }

    // Update is called once per frame

}
