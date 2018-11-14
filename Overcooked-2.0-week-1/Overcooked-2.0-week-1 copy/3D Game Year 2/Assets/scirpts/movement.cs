using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{

    public float moveSpeed;



    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public Rigidbody myRigidBody;


    public bool useController;

    // Use this for initialization
    void Start()
    {
     




    }


    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;








    }



    void FixedUpdate()
    {
        myRigidBody.velocity = moveVelocity;
    }




}