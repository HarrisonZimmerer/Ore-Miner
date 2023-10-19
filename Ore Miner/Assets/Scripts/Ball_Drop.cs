using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Drop : MonoBehaviour
{
    public float distanceFromCamera = 10f;
    public float topScreen = 6f;
    public GameObject spawnObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // PutBalls(Input.mousePosition);
            spawnBall();
        }
    }
    public void spawnBall()
    {
        Vector3 mousePos = Input.mousePosition;
        float y = topScreen;
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, distanceFromCamera));
        Debug.Log(mousePos);
        
        GameObject.Instantiate(spawnObject, mousePos, Quaternion.identity);
        Debug.Log("WORK");
    }
   /* public void PutBalls(Vector2 mousePosition)
    {
        RaycastHit hit = RayFromCamera(mousePosition, 3000.0f);
        GameObject.Instantiate(spawnObject, hit.point, Quaternion.identity);
    }

    public RaycastHit RayFromCamera(Vector3 mousePosition, float rayLength)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        Physics.Raycast(ray, out hit, rayLength);
        return hit;
    }
    */
}
