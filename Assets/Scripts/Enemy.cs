using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 speed;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.velocity = speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        speed = -speed;
    }
}
