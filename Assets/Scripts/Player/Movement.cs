using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController controller;
    Vector3 velocity;
    bool isGrouded;
    public Transform ground;
    public float distance = 0.3f;
    public float speed;
    public float gravity;
    public float jumpHeight;
    public LayerMask mask;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        speed = 50;
     
        
        
        #region Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 hareket = transform.right * horizontal + transform.forward * vertical;
        controller.Move(hareket * speed * Time.deltaTime);

        #endregion



        #region Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrouded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight += 3.0f * gravity);
        }
        #endregion
        #region Gravity
        isGrouded = Physics.CheckSphere(ground.position, distance, mask);
        if (isGrouded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        #endregion
        #region Sprint
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
        #endregion
        

    }
}
