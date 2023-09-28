using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public Vector3 spawnPoint;
    Rigidbody rb;
    private void Start()
    {
        spawnPoint = transform.position;
        rb = GetComponent<Rigidbody>();
    }
    public void Die()
    {
        var sceneNow = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneNow);
    }
    void Update()
    {
        Vector3 movedirection = new Vector3();
        movedirection.x = Input.GetAxisRaw("Horizontal");
        movedirection.z = Input.GetAxisRaw("Vertical");
        //transform.position += movedirection * speed * Time.deltaTime;
        rb.velocity = movedirection * speed;
        if(movedirection != Vector3.zero)transform.forward = movedirection;

        /*if (Input.GetKey(KeyCode.D))
        {
        GetComponent<Transform>().position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += new Vector3(0, 0, speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += new Vector3(0, 0, -speed) * Time.deltaTime;
        }*/
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            Die();
        }
    }
}
