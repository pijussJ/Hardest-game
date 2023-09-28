using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    public float speed;
    private Transform target;
    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    void Update()
    {
        // rotation
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        // collision
        var distance = Vector3.Distance(transform.position, target.position);

        if (distance < 1f)
        {
            target.position = target.GetComponent<Player>().spawnPoint;
        }
    }
}
