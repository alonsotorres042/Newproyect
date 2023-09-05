using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    private float _speedX = 15;
    private float _speedY = 15;
    private Rigidbody2D _rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        _rigidBody2D.position = new Vector2(_rigidBody2D.position.x + _speedX * _horizontal * Time.deltaTime, _rigidBody2D.position.y + _speedY * _vertical * Time.deltaTime);
    }
}
