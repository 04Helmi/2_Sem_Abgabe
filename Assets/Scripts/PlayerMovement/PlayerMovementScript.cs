using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    //References
    Rigidbody2D rb;
    PlayerInput input;

    //Variable
   [SerializeField] private float speed;

    private float movementInput;

    private void Awake()
    {
        input = new PlayerInput();

        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
     
    }

    private void FixedUpdate()
    {
       rb.velocity = new Vector2(movementInput*speed, rb.velocity.y); 
    }
    private void OnMove(InputValue inputValue)
    { 
        movementInput = inputValue.Get<float>();
        Debug.Log(movementInput);
    }

}
