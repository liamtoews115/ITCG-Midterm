using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject sonic;
    public Rigidbody rb;
    private Rigidbody _rb;
    public SphereMove _sonic;
    public int speed;

    public bool canSwitch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rb.linearVelocity = (new Vector3(speed,0,0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.linearVelocity = (new Vector3(-speed,0,0));
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && canSwitch)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            sonic.GetComponent<MeshRenderer>().enabled = true;
            canSwitch = false;
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        

        if (Input.GetKeyUp(KeyCode.Space))
        {
            canSwitch = true;
            _sonic.grounded = false;
        }
        
    }
}
