using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody body;
    [SerializeField] private float speed = 1;
    [SerializeField] private float upForce = 1;

    public delegate void OnProgression(bool status);
    public OnProgression OnLevelProgression;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            body.AddForce(-Physics.gravity.normalized * upForce, ForceMode.Impulse);
        }

        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!enabled) return;
        body.isKinematic = true;
        enabled = false;
        if (OnLevelProgression != null)
        { 
            if(collision.collider.CompareTag("Finish"))
                OnLevelProgression.Invoke(true);
            else
                OnLevelProgression.Invoke(false);
        }
    }
}
