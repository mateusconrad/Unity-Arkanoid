using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredinha : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rigidbody;
    public BoxCollider2D collider; 

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D> ();
        collider = GetComponent<BoxCollider2D> ();
    }

    // Update is called once per frame


    void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.constraints = new RigidbodyConstraints2D ();
        collider.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D collision){
        GameObject.Destroy(collider.gameObject);
    }

}