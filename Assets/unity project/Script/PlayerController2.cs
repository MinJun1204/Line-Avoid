using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(new Vector3(0.09f, 0, 0));
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3 (transform.position.x, 0.28f, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3 (transform.position.x, -0.28f, 0);
        }
    }
}
