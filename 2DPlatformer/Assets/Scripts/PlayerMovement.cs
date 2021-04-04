using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 25f;
    private float horizontalMode = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontalMode = Input.GetAxisRaw("Horizontal") * runSpeed;
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMode * Time.fixedDeltaTime, false, false);
    }
}
