using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    private Rigidbody _bod;
    public float _baseSpeed = 10;
    private float _moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _bod = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Cursor.visible)
        {
            Vector3 velocity = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                velocity += transform.forward;
            }
            if (Input.GetKey(KeyCode.A))
            {
                velocity += transform.right * -1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                velocity += transform.forward * -1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                velocity += transform.right;
            }
            velocity.Normalize();
            _moveSpeed = Mathf.Max(0, _baseSpeed - _bod.velocity.sqrMagnitude);
            _bod.AddForce(velocity * _moveSpeed);
        }
    }
}
