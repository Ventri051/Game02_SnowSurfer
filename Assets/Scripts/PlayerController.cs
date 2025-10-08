using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
 InputAction moveAction;
    Rigidbody2D myRigidBody2D;
    [SerializeField] float torqueAmount = 1f;
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
         
    }


    void Update()
    {


        Vector2 moveVector;
        moveVector = moveAction.ReadValue<Vector2>();
        print(moveVector);
        if (moveVector.x > 0)
        {
            myRigidBody2D.AddTorque(torqueAmount);
        }
          else if (moveVector.x > 0)
        {
            myRigidBody2D.AddTorque(-torqueAmount);
        }
    }
}
