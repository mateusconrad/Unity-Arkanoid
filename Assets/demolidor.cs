using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demolidor : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collider = collision.collider.gameObject;
        GameObject.Destroy(collider);
    }

    void OnTriggerEnter2D(Collider2D collision){
        GameObject.Destroy(GetComponent<Collider>().gameObject);
    }

}
