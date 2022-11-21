using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotation : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    private void FixedUpdate()
    {
        transform.forward =
            Vector3.Slerp(transform.forward, rb.velocity.normalized, Time.fixedDeltaTime);
    }

}
