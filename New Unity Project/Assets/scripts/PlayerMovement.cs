using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode _left;
    public KeyCode _right;
    public KeyCode _jump;

    public CharacterController _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.isGrounded == true)
        {
            if(Input.GetKeyDown(_jump))
            {

            }
        }
    }
}
