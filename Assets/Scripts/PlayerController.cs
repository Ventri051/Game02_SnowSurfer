using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    Rigidbody2D myRigidBody2D;
    SurfaceEffector2D surfaceEffector2D;

    Vector2 moveVector;

    
    
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float baseSpeed = 25f;
    [SerializeField] float boostSpeed = 32f;
    
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
         
    }
    void Update()
    {
        RotatePlayer();
        BoostPlayer();  
    }
    void RotatePlayer()
    {
         moveVector = moveAction.ReadValue<Vector2>();
     if (moveVector.x < 0)
        {
            myRigidBody2D.AddTorque(torqueAmount);
        }
        else if (moveVector.x > 0)
        {
            myRigidBody2D.AddTorque(-torqueAmount);
        }
    }
    void BoostPlayer()
    {
        if (moveVector.y > 0)
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
