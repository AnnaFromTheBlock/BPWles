using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class winnersScript : MonoBehaviour
{

    public GameObject Player;
    public GameObject WinnersCube;
    public GameObject Cube;
    private bool PlayerTrue;
    private bool CubeTrue;
    public void OnTriggerEnter(Collider Coll)
    {
        
        if (Coll.gameObject.CompareTag("Player"))
        {
            PlayerTrue = true;
        }
        if ((Coll.gameObject.CompareTag("Cube")))
        {
            CubeTrue = true;
        }

        if (CubeTrue && PlayerTrue)
        {
            Debug.Log("Triggered");
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }



    // Start is called before the first frame update
    void Start()
    {
    

    }
}
