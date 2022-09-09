using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        var torque = other.GetComponent<BoostController>().torque;
        if (other.gameObject.CompareTag("Boost")) rb.AddForce(transform.right * torque, ForceMode.Impulse);
    }
}