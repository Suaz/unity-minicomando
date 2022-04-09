using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float distance = 6f;
    public Transform target;
    float mouseX, mouseY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        Vector3 angle = transform.eulerAngles;
        angle.y += Input.GetAxis("Mouse X");
        transform.eulerAngles = angle;
        transform.position = target.position - transform.forward * distance;
    }
}
