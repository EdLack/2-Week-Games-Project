using UnityEngine;

public class TiltControl : MonoBehaviour
{
    public float tiltSpeed = 5f; 
    public float maxTiltAngle = 10f; 

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float tiltInputX = Input.GetAxis("Horizontal"); 
        float tiltInputZ = Input.GetAxis("Vertical");

        Quaternion targetTilt = Quaternion.Euler(tiltInputZ * maxTiltAngle, 0f, -tiltInputX * maxTiltAngle);

        rb.rotation = Quaternion.Lerp(rb.rotation, targetTilt, tiltSpeed * Time.deltaTime);
    }
}
