using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
            ApplyMagnus();
            Debug.Log("kick");
        }
        //ApplyMagnus();
    }

    void Kick()
    {
        rb.linearVelocity = velocity; //kickforce
        rb.angularVelocity = spin; //spimforce
    }

    void ApplyMagnus()
    {
        Vector3 magnusForce = Vector3.Cross(velocity, spin);

        rb.AddForce(magnusForce);
    }
}
