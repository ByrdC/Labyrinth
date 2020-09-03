using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4.0f;

    private Vector2 direction = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        UpdateOrientation();
    }

    void CheckInput ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
            Move();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
            Move();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
            Move();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
            Move();
        }
    }

    void Move ()
    {
        transform.localPosition += (Vector3) (direction * speed) * Time.deltaTime;
    }

    void UpdateOrientation()
    {
        if (direction == Vector2.left)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        else if (direction == Vector2.right)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
