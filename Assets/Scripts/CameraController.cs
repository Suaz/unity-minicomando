using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float speed = 24f;
    float rotationSpeed = 32f;
    void Update()
    {

        float updatedSpeed = rotationSpeed * Time.deltaTime;

        


        //if (Input.GetKey(KeyCode.Q))
        //{
        //    transform.Rotate(0f, updatedSpeed, 0f, Space.World);
        //    transform.Rotate(-updatedSpeed, 0f, 0f, Space.Self);

        //    //transform.Rotate(0,rotationSpeed * Time.deltaTime, 0,Space.World);
        //}

        //if (Input.GetKey(KeyCode.E))
        //{
        //    transform.Rotate(0f, -updatedSpeed, 0f, Space.World);
        //    transform.Rotate(updatedSpeed, 0f, 0f, Space.Self);

        //    //transform.Rotate(0, - rotationSpeed * Time.deltaTime, 0,Space.World);
        //}

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0,0, -speed * Time.deltaTime,  Space.World);
        }
    }

}
