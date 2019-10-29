using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public LayerMask mask;
    Collider[] colliders;
    public float radius = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        colliders = Physics.OverlapSphere(transform.position, radius, mask);
    }

    // Update is called once per frame
    void Update()
    {
        colliders = Physics.OverlapSphere(transform.position, radius, mask);
        for(uint i = 0; i < colliders.Length; i++)
        {
            if(colliders[i].gameObject.name == "Player")
                Debug.Log("Collided with " + colliders[i].gameObject.ToString());
        }
    }
}
