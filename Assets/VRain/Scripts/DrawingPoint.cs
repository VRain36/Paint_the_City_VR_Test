using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DrawingPoint : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent OnExit;

    private void OnTriggerEnter(Collider other)
    {
        TrigExit.instance.currentCollider = GetComponent<DrawingPoint>();
        OnEnter.Invoke();
    }
}
