using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect3 : MonoBehaviour
{   
    public GameObject A;
    void Start()
    {
        gameObject.GetComponent<PlayerController>().enabled = false;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("obstacle"))
        {
            SceneManager.LoadScene("LV3sel");
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

    }
}