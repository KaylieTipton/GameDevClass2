using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickupItem : MonoBehaviour
{

    public GameObject pickupEffect;
    public GameObject lookHereEffect;
    public GameObject lookHereEffect1;
    public GameObject lookHereEffect2;
    public GameObject lookHereEffect3;

    private int count;

    public GameObject winMenu;
    public GameObject winText;
    public TextMeshProUGUI countText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winMenu.SetActive(false);
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
            FindObjectOfType<AudioManager>().Play("PickUpSound");
            count++;
            SetCountText();
            Instantiate(pickupEffect, transform.position, transform.rotation);
            lookHereEffect.gameObject.SetActive(false);

        }
        if (key.gameObject.CompareTag("Key1"))
        {
            key.gameObject.SetActive(false);
            FindObjectOfType<AudioManager>().Play("PickUpSound");
            count++;
            SetCountText();
            Instantiate(pickupEffect, transform.position, transform.rotation);
            lookHereEffect1.gameObject.SetActive(false);
        }
        if (key.gameObject.CompareTag("Key2"))
        {
            key.gameObject.SetActive(false);
            FindObjectOfType<AudioManager>().Play("PickUpSound");
            count++;
            SetCountText();
            Instantiate(pickupEffect, transform.position, transform.rotation);
            lookHereEffect2.gameObject.SetActive(false);
        }
        if (key.gameObject.CompareTag("Key3"))
        {
            key.gameObject.SetActive(false);
            FindObjectOfType<AudioManager>().Play("PickUpSound");
            count++;
            SetCountText();
            Instantiate(pickupEffect, transform.position, transform.rotation);
            lookHereEffect3.gameObject.SetActive(false);
        }
    }

    void SetCountText()
    {
        countText.text = "Key Count: " + count.ToString();
        if(count >= 4)
        {
            winMenu.SetActive(true);
            winText.SetActive(true);
        }
    }

}
