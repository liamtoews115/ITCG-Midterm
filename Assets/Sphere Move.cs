using System;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    public GameObject sonic;
    public Movement movement;
    public bool grounded = false;

    public Vector3 land;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space) && movement.canSwitch)
        {
            this.gameObject.SetActive(false);
            sonic.SetActive(true);
            movement.canSwitch = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            movement.canSwitch = true;
        }*/
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!grounded)
        {
            this.gameObject.SetActive(false);
            sonic.SetActive(true);
            movement.canSwitch = true;
            grounded = true;
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        grounded = false;
    }
}
