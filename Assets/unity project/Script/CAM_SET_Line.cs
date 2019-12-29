using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM_SET_Line : MonoBehaviour
{        
        
    public GameObject A;  //A라는 GameObject변수 선언
    Transform AT;
    void Start ()
    {
        AT=A.transform;
    }
    void LateUpdate () 
    {
        transform.position = new Vector3 (AT.position.x,0,-1);
    }
}