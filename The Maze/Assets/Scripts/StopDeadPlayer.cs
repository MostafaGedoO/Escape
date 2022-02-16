using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class StopDeadPlayer : MonoBehaviour
{
    Rigidbody rb;
    FirstPersonController firstPersonController;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        firstPersonController = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Dead.IsDead)
        {
            firstPersonController.enabled = false;
            rb.useGravity = false;
        }
    }
}
