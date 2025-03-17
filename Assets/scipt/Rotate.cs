using UnityEngine;


public class Rotate : MonoBehaviour 
{
    [SerializeField] Vector3 angularVelocity, torque;
    Rigidbody rb;
    //[SerializeField]Vector3 angularVelocity , torque ;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularVelocity;
            Debug.Log("velo");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
            Debug.Log("spim");
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.angularVelocity = Vector3.zero;
            Debug.Log("cube stop");
        }
    }
}
