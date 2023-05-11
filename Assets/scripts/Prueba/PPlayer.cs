using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float forceJump;
    public Animator myAnimator;
    PControl _control;
    PMovement _movement;
    public float Life;

    void Start()
    {
        _movement = new PMovement(transform, rb, speed, forceJump);
        _control = new PControl(_movement);
    }

    void Update()
    {
        _control.ArtificialUpdate();

        //Animacion
   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetBool("jumping", true);
        }
        else

        {
            myAnimator.SetBool("jumping", false);
            myAnimator.SetFloat("Vertical", Input.GetAxis("Vertical")); 
            myAnimator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
           

        }
    }

    public void PSpeedUp(float add)
    {
        _movement.SpeedUp(add);
    }

    public void ForceJumpUp(float add)
    {
        _movement.ForceJumpUp(add);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _movement.ArtificialOnCollisionEnter(collision);
    }

    private void OnTriggerEnter(Collider other)
    {
        var powerUp = other.GetComponent<PPowerUp>();

        if (powerUp != null)
            powerUp.Get(this);
    }
   

       




    

}