using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;

    public AudioClip openDoorSound;
    public AudioClip clseDoorSound;
    public AudioSource source;

    private void Start()
    {
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("doorOpen", true);
        source.PlayOneShot(openDoorSound);
    }

    private void OnTriggerStay(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("doorOpen", false);
        source.PlayOneShot(clseDoorSound);
    }
}
