using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Rigidbody rigidbody;

    [SerializeField]
    private Transform startPosition;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (rigidbody.IsSleeping())
        {
            rigidbody.WakeUp();
        }
    }

    public void ToStartPosition()
    {
        transform.position = startPosition.position;
        rigidbody.velocity = new Vector3(0, 0, 0);
    }
}
