using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickablePlayer : MonoBehaviour
    
{
    public LayerMask clickableLayer;
    private NavMeshAgent myAgent;
    public bool selected;
    Animator animator;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        Outline outline = GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineMode = Outline.Mode.OutlineAll;
            outline.OutlineWidth = selected ? 4f : 0f;
        }

        if (Input.GetMouseButton(1) && selected)
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(myRay,out hitInfo, 100, clickableLayer))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }
        animator.SetFloat("movementSpeed", myAgent.hasPath ? 2 : 0);
    }
}
