using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speeder : MonoBehaviour
{
    [SerializeField] float force;

    bool isSpeeding;

    private void OnCollisionEnter(Collision other)
    {
        if (isSpeeding == false &&
           other.transform.CompareTag("bola") &&
           other.transform.TryGetComponent<Rigidbody>(out var rb))
        {
            rb.AddForce(force * this.transform.forward, ForceMode.Impulse);
            isSpeeding = true;
            Invoke("Reset", 0.3f);
        }

    }
    private void Reset()
    {
            isSpeeding = false;        
    }

}
