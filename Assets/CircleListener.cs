using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleListener : MonoBehaviour
{

    public void OnEnable()
    {
        Actions.InteractStartedEvent += CircleInteractMethod;
    }

    public void OnDisable()
    {
        Actions.InteractStartedEvent -= CircleInteractMethod;
    }

    public void CircleInteractMethod()
    {
        Debug.Log("Circle is moving");
        transform.position += Vector3.up;
    }
}
