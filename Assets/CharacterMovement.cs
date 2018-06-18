using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    private NavMeshAgent myNavMeshAgent;

    void Awake()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		MoveToClick();
	}

    public void MoveToClick()
    {
        if (Input.GetMouseButton(1))  //input
    
        {
            Ray tempRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit tempHit;
            if (Physics.Raycast(tempRay, out tempHit, 100f))
            {
                if(!tempHit.collider) return;

                myNavMeshAgent.SetDestination(tempHit.point);

            }


        }
    }

    
}
