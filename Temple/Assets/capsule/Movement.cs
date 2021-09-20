using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    // Start is called before the first frame update
    Vector2 horizontalInput;
  //  [SerializeField] float gravity = -3.29f;
   // Vector3 verticalVelocity = Vector3.zero;
    private void Update()
    {
        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);
       // verticalVelocity.y += (gravity * Time.deltaTime);
      //  controller.Move(verticalVelocity * Time.deltaTime);
    }
    public void ReceiveInput (Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
        print(horizontalInput);
    }
}
