using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float smoothTime = .5f;
    public float gravity = 10f;
    public float jumpForce = 5f;
    Camera camera;

    public Vector3 velocity;
    CharacterController controller;

    float velocitySmoothingX, velocitySmoothingZ;

    public int characterKey;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        camera = Camera.main;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector3 direction = new Vector3(input.x, 0, input.y);

        direction = Quaternion.AngleAxis(camera.transform.eulerAngles.y, Vector3.up) * direction;


        float targetVelocityX = direction.x * movementSpeed;
        float targetVelocityZ = direction.z * movementSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocitySmoothingX, smoothTime);
        velocity.z = Mathf.SmoothDamp(velocity.z, targetVelocityZ, ref velocitySmoothingZ, smoothTime);
        velocity.y -= gravity * Time.deltaTime;
        //if (controller.isGrounded && Input.GetButtonDown("Jump"))
        //{
        //    velocity.y = jumpForce;
        //}
        controller.Move(velocity * Time.deltaTime);

        animator.SetFloat("movementSpeed", input.magnitude);


        float yPivotRotation = camera.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, yPivotRotation, 0);

        //if (controller.isGrounded)
        //    velocity.y = 0;

    }
    
}
