using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    private bool twod = true;

    private Vector3 movementVec;
    private CharacterController CharCon;
    private float moveSpeed = 10f;
    private float jumpheight = 20f;
    private float gravity = 40f;
    public float xmovement;
    public float ymovement;
    public float xRote;
    public float yRote;
    // Use this for initialization
    void Start()
    {
        CharCon = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    public void movePlayer()
    {
        //  movementVec.x = Input.GetAxis("LeftStickX") * moveSpeed;
        // movementVec.z = Input.GetAxis("LeftStickY") * moveSpeed;
        xmovement = Input.GetAxisRaw("LeftStickX");
        ymovement = Input.GetAxisRaw("LeftStickY");

        if (xmovement == 1 || xmovement == -1)
        {
            movementVec.x = xmovement * moveSpeed;
        }
        else
        {
            movementVec.x = 0;
        }

        


        if (CharCon.isGrounded)
        {
            movementVec.y = 0;

            if (Input.GetButtonDown("A"))
            {
                movementVec.y = jumpheight;

            }
        }
        movementVec.y -= gravity * Time.deltaTime;
        CharCon.Move(movementVec * Time.deltaTime);
    }
    public void rotatePlayer()
    {
        xRote = Input.GetAxisRaw("RightStickY");
        yRote = Input.GetAxisRaw("RightStickX");


    }
}










