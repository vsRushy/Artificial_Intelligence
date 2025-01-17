﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveToMouseClick : MonoBehaviour
{
    public LayerMask mask;
    public GameObject[] sendGoal;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {       
            RaycastHit hit;
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(r, out hit, 10000.0f, mask) == true)
                transform.position = hit.point;

            foreach(GameObject go in sendGoal)
            {
                if(go != null && go.GetComponent<UnityEngine.AI.NavMeshAgent>() != null)
                {
                    go.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = transform.position;
                }
            }
        }
    }
}