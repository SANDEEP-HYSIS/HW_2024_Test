using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody player;
    private float movespeed = 30f;
    private float turnSpeed = 100f;
    private int score = 0;
    [SerializeField] Text Score;
    void Start()
    {
        player = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {  if(transform.position.y<0)
        {   
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
       transform.Rotate(Vector3.up*turnSpeed*Input.GetAxis("Horizontal")*Time.deltaTime);
       transform.Translate(0f,0f,movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {   if(collision.gameObject!=null)
        {
            Destroy surface = collision.gameObject.GetComponent<Destroy>();
            if (!surface.getVariable())
            {
                surface.SetVariable();
                score++;
                Score.text = "Score :" + score;
            }
        }
    }
}
