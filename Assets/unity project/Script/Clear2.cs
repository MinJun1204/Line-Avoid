using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear2 : MonoBehaviour
{        
    public GameObject B;   
    public GameObject A;  //A라는 GameObject변수 선언
    Transform AT;
    void Start ()
    {
        B.GetComponent<Renderer>().enabled = false;
        AT=A.transform;
    }
    void LateUpdate () 
    {
        transform.position = new Vector3 (AT.position.x,1.75f,0);
        if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("LV2sel");
            }
    }
}