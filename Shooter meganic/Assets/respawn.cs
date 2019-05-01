using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour
{
    public float threshold;

    void Update()
    {
        if (transform.position.y < threshold) {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(0, 0, 0);
            GetComponent<CharacterController>().enabled = true;
       
        }
    

    }
}
