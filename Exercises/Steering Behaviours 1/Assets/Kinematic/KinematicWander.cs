using UnityEngine;
using System.Collections;

public class KinematicWander : MonoBehaviour
{
	public float max_angle = 0.5f;

    public float wander_rate = 1.0f;
    public float timer = 0.0f;

	Move move;

	// Use this for initialization
	void Start ()
    {
		move = GetComponent<Move>();
	}

	// Update is called once per frame
	void Update () 
	{
        timer += Time.deltaTime;

        // TODO 9: Generate a velocity vector in a random rotation (use RandomBinominal) and some attenuation factor
        if (timer >= wander_rate)
        {
            float angle = RandomBinomial() * max_angle;
            Vector3 velocity = Quaternion.AngleAxis(Mathf.Rad2Deg * angle, Vector3.up) * Vector3.forward;
            velocity *= move.max_mov_velocity;

            move.SetMovementVelocity(velocity);

            timer = 0.0f;
        }
    }

    float RandomBinomial()
    {
        return Random.Range(-1.0f, 1.0f);
    }
}
