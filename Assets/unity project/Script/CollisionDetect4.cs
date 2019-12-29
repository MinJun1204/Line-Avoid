using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect4 : MonoBehaviour
{   
    public GameObject A;
    public GameObject B;
    void Start()
    {
        gameObject.GetComponent<PlayerController>().enabled = false;
        B.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("obstacle"))
        {
            SceneManager.LoadScene("LV4sel");
        }
        if (other.gameObject.tag.Equals("goal"))
        {
            A.GetComponent<Renderer>().enabled = true;
        }
        if (other.gameObject.tag.Equals("faster"))
        {
            gameObject.GetComponent<PlayerController2>().enabled = false;
            gameObject.GetComponent<PlayerController>().enabled = true;
        }
        else if (other.gameObject.tag.Equals("slower"))
        {
            gameObject.GetComponent<PlayerController>().enabled = false;
            gameObject.GetComponent<PlayerController2>().enabled = true;
        }
        else if (other.gameObject.tag.Equals("blackout"))
        {
            B.GetComponent<Renderer>().enabled = true;
        }

    }
}