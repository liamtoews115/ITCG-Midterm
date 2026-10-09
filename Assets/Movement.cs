using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject sonic;
    public Rigidbody rb;
    public SphereMove _sonic;

    public bool canSwitch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && canSwitch)
        {
            this.gameObject.SetActive(false);
            sonic.SetActive(true);
            canSwitch = false;
            rb.AddForce(Vector3.up * 10,  ForceMode.Impulse);
        }
        

        if (Input.GetKeyUp(KeyCode.Space))
        {
            canSwitch = true;
            _sonic.grounded = false;
        }
        
    }
}
