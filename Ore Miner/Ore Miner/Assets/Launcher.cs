using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{     
    public GameObject LaunchPoint;

    void Awake()
    {
        Transform LaunchPointTrans = transform.Find("LaunchPoint");
        LaunchPoint = LaunchPointTrans.gameObject;
        LaunchPoint.SetActive(false);
    }

    void OnMouseEnter()
    {
        LaunchPoint.SetActive(true);
    }
    void OnMouseExit()
    {
        LaunchPoint.SetActive(false);
    }

}
