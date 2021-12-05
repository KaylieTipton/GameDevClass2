using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupItem : MonoBehaviour
{

    public GameObject pickupEffect;
    public GameObject lookHereEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider key)
    {
        if (key.gameObject.CompareTag("Key"))
        {
            key.gameObject.SetActive(false);

            Instantiate(pickupEffect, transform.position, transform.rotation);
            lookHereEffect.gameObject.SetActive(false);

        }
    }

}
