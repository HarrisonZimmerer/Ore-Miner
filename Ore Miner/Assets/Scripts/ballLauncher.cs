using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLauncher : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject projectilePrefab;

    [Header("Dynamic")]
    public GameObject Launchpoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;

    void Awake()
    {
        Transform LaunchPointTrans = transform.Find("Launchpoint");
        Launchpoint = LaunchPointTrans.gameObject;
        //Launchpoint.setActive(false);
        launchPos = LaunchPointTrans.position;
    }

    void OnMouseDown()
    {
        aimingMode = true;
        projectile = Instantiate(projectilePrefab) as GameObject;
        projectile.transform.position = launchPos;
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }

    void OnMouseEnter()
    {
        Launchpoint.SetActive(true);
    }

    void OnMouseExit()
    {
        Launchpoint.SetActive(false);
    }

}
