using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public CharacterController characterController;
    Vector3 moveVector;
    public float moveSpeed;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical")*transform.forward;

        characterController.Move(moveVector);
        Debug.Log(moveVector*moveSpeed*Time.deltaTime);
    }
}
