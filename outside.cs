using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class outside : MonoBehaviour
{
    public UnityEvent OnBallEnter = new UnityEvent();

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.CompareTag("Bola"))
        {
            OnBallEnter.Invoke();
        }
    }
}
