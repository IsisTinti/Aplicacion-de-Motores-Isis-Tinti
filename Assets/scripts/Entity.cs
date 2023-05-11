using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class Entity : MonoBehaviour
{
    public float speed;
    public float forceJump;
    public Rigidbody rb;
    public float rotationSpeed;
    public Control _control;
    public Character _movement;
    public Animator myAnimator;
    public int Life;
    public int Damage;

   public void Start()
    {
        _movement = new Character(transform, rb, speed, forceJump,rotationSpeed);
        _control = new Control(_movement);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
          
            SceneManager.LoadScene("TestingMode");
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetBool("jumping", true);
        }
        else

        {
            myAnimator.SetBool("jumping", false);
            myAnimator.SetFloat("Vertical", Input.GetAxis("Vertical"));
            myAnimator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            _control.AUpdate();
           
        }*/

    }
}
