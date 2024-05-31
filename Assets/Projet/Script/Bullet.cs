using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(1,10)]
    [SerializeField] private float speed = 10f;
    [Range(1,10)]
    [SerializeField] private float lifeTime = 2f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on " + gameObject.name);
            return;
        }
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (rb != null)
        {
            rb.velocity = transform.up * speed;
            Debug.Log("Bullet moving with velocity: " + rb.velocity);
        }
    }
}
