using UnityEngine;
using System.Collections;

public class Respawn_Cube : MonoBehaviour
{
    public float thresholds;

    void FixedUpdate()
    {
        if (transform.position.y < thresholds)
            transform.position = new Vector3(-9, 1, 0);
    }
}