using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class RigidBodyCharacterController : MonoBehaviour
{
    Rigidbody rigidbody;

    float xInput = 0;
    float yInput = 0;
    bool jump = false;
    bool allowJump = false;
    [SerializeField]
    float rayLength = 1;
    RaycastHit raycastHit;
    [SerializeField]
    int sensitive = 80;
    [SerializeField]
    int dragging = 3;
    [SerializeField]
    int maxSpeed = 50;
    [SerializeField]
    float jumpForce = 30;
    [SerializeField]
    float gravityA = 40;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
        Physics.gravity = new Vector3(0, -gravityA, 0);


    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        jump = Input.GetKey(KeyCode.Space);

        allowJump = Physics.Raycast(transform.position, Vector3.down, out raycastHit, rayLength);
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3(xInput, 0, yInput).normalized * sensitive;
        rigidbody.AddForce(move);
        rigidbody.drag = dragging;
        rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, maxSpeed);
        if (jump && allowJump)
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z);
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
    }
  

}