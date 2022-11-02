using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Marios;
    int Level = 1;
    int LevelUp = 1;
    private bool jumpWasPressed;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        Marios = "marios";
        Debug.Log(Marios);
        Debug.Log(Level);
        Debug.Log(Level + LevelUp);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ = Level + LevelUp;
        }
        Debug.Log(Input.GetKeyDown(KeyCode.Space));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpWasPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        if (jumpWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpWasPressed = false;
        }
        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);


    }
}
