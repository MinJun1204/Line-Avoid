using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{   
    public GameObject A;
    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("obstacle"))
        {
            SceneManager.LoadScene("select LV");
        }
        if (other.gameObject.tag.Equals("goal"))
        {
            A.GetComponent<Renderer>().enabled = true;
        }
    }
}