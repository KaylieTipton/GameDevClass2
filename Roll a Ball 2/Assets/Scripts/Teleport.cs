using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform destination;
    public GameObject player;

    private MeshRenderer mr; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Teleport");
            //other.transform.position = destination.position;
            other.GetComponent<MeshRenderer>().enabled = false;
        }



    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
