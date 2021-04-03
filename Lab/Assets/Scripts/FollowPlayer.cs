using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject ViewCamera = null;
    private Rigidbody mRigidBody = null;

    public const double V = 0.30;
    public const double C = 2.50;
    private float CameraUp = (float)V;
    private float CameraBack = (float)C;

    // Start is called before the first frame update
    void Start()
    {
        mRigidBody = GetComponent<Rigidbody>();
    }
    //Camera Follows Player 
    void FixedUpdate()
    {
        if (ViewCamera != null)
        {
            Vector3 direction = (Vector3.up * CameraUp + Vector3.back) * CameraBack;
            {

                ViewCamera.transform.position = transform.position + direction;

            }
            ViewCamera.transform.LookAt(transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
