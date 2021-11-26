using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotateSpeed = 3.0f;

    Animator anim;
    CharacterController controller;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float currentSpeed = speed * vertical;
        
        transform.Rotate(0, horizontal * rotateSpeed, 0);    
        controller.SimpleMove(forward * currentSpeed);

        if (currentSpeed != 0)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
}