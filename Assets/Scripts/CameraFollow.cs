using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target = null;
    [SerializeField] private float speed = 1;
    void Start()
    {
        
    }


    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
                                         new Vector3(target.position.x, transform.position.y, transform.position.z),
                                         speed * Time.deltaTime);
    }
}
