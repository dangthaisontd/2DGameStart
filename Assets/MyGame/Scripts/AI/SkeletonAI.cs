using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("DangSon/SkeletonAI")]
public class SkeletonAI : MonoBehaviour
{
    public float Speed = 2;
    public Transform pointA;
    public Transform pointB;
    public float MinDistance = 0.01f;
    private Transform target;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
        transform.position = pointA.position;
        target = pointB;
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }
    void Patrol()
    {
        if(Vector2.Distance(transform.position,target.position) < MinDistance)
        {
          target = target == pointA ? pointB : pointA;
        }
        Vector2 direction = (target.position-transform.position).normalized;
        rb.velocity = direction * Speed;   
    }
}
