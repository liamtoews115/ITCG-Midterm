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
        this.transform.position = (new Vector3(sonic.transform.position.x,gameObject.transform.position.y,sonic.transform.position.z));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!grounded)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            sonic.GetComponent<MeshRenderer>().enabled = true;
            movement.canSwitch = true;
            grounded = true;
            sonic.transform.position = gameObject.transform.position + new Vector3(0,1,0);
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        grounded = false;
    }
}
