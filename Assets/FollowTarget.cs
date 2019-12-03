using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform _target;
    public Vector3 _posOffset;
    public float _moveLerpSpeed;
    public float _turnLerpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position+_posOffset, _moveLerpSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, _target.rotation, _turnLerpSpeed * Time.deltaTime);
    }
}
