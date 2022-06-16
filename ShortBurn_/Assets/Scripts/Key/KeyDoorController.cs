using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoorController : MonoBehaviour
{
    [SerializeField] private float timeToTurn = 2;
    [SerializeField] private Vector3 rotate;
    
    
    public void OpenDoor()
    {
        StartCoroutine(RotateMe(rotate, timeToTurn));
    }

    IEnumerator RotateMe(Vector3 byAngles, float time) 
    {    
        Quaternion fromAngle = transform.rotation;
        Quaternion toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        
        for(var t = 0f; t < 1; t += Time.deltaTime/time) {
            transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
    }
}
