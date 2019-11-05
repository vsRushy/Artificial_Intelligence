using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knowledge : MonoBehaviour
{
    public GameObject game_object;
    public Vector3 position;
    public float time_stamp;
    public bool past_memory;

    public Knowledge(GameObject game_object, Vector3 position, float time_stamp, bool past_memory)
    {
        this.game_object = game_object;
        this.position = position;
        this.time_stamp = time_stamp;
        this.past_memory = past_memory;
    }

    public void Update()
    {

    }
}
