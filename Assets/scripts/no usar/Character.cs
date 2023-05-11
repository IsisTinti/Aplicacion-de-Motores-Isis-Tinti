using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Character : Entity
{
    Transform _transform;

    public Rigidbody _rb;
    public float _forceJump;
    public float _speed;
    public float _rotationSpeed;

    public Character(Transform t, Rigidbody rb, float speed, float fj, float rotationSpeed)
    {
        _forceJump = fj;
        _speed = speed;
        _transform = t;
        _rb = rb;
        _rotationSpeed = rotationSpeed;
    }


    public void Move(float v, float h)
    {

        var dir = _transform.forward * v;
        dir += _transform.right * h;
        _transform.position += dir * _speed * Time.deltaTime;
        _transform.Rotate(0, h * Time.deltaTime * _rotationSpeed, 0);
        /*   Debug.Log(_speed +","+ _forceJump);
        if (v >= 0.1f || v<= -0.1f)
        {
            float TargetAngle = Mathf.Atan2(v, h) * Mathf.Rad2Deg;

        }
    }
    public void Jump()
        {
            _rb.AddForce(Vector3.up * _forceJump, ForceMode.Impulse);
        }
    /*
    void Start()
    {
        _movement = new Character(transform, rb, speed, forceJump, rotationSpeed);
        _control = new Control(_movement);
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetBool("jumping", true);
        }
        else

        {
            myAnimator.SetBool("jumping", false);
            myAnimator.SetFloat("Vertical", Input.GetAxis("Vertical"));
            myAnimator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            _control.AUpdate();

        }




    }*/
    }
}