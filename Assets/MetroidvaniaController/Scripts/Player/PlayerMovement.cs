using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    [SerializeField] GameManager gameManager;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool dash = false;

    //bool dashAxis = false;

    // Update is called once per frame
    void Update()
    {
        if (gameManager.IsLevelStarted)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetKeyDown(KeyCode.W) )
            {
                jump = true;
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                dash = true;
            }

            /*if (Input.GetAxisRaw("Dash") == 1 || Input.GetAxisRaw("Dash") == -1) //RT in Unity 2017 = -1, RT in Unity 2019 = 1
    {
        if (dashAxis == false)
        {
            dashAxis = true;
            dash = true;
        }
    }
    else
    {
        dashAxis = false;
    }
    */
        }
    }

    public void OnFall()
    {
        animator.SetBool("IsJumping", true);
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
        jump = false;
        dash = false;
    }
}