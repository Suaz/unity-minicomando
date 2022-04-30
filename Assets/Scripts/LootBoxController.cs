using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBoxController : MonoBehaviour
{
    Animator animator;
    AudioSource source;
    [SerializeField] WeaponController[] weapons;
    void Awake()
    {
        
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        //foreach (WeaponController weapon in weapons)
        //{
        //    Debug.Log(weapon.gameObject.name);
        //    weapon.gameObject.SetActive(true);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
     
     
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.GetComponent<ClickablePlayer>())
        {
            OpenLootBox();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //animator.SetBool("Checked", false);
    }

    private void OpenLootBox()
    {
        animator.SetBool("lootBoxOpened", true);
        source.Play();

        foreach(WeaponController weapon in weapons)
        {
            Debug.Log(weapon.gameObject.name);
            weapon.gameObject.SetActive(true);
        }
    }
}
