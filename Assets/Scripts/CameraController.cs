using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   
    float distance = 1f;
    public Transform target;
    float mouseX, mouseY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       

        Vector3 newPosition = target.position;
        newPosition.y += 1.5f;
        //newPosition.y *=-1;
        Vector3 angle = transform.eulerAngles;
        angle.y += Input.GetAxis("Mouse X");
        angle.x += Input.GetAxis("Mouse Y");
        transform.eulerAngles = angle;
        transform.position = newPosition - transform.forward * distance;
    }
}
