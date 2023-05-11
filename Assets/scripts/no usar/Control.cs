using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control
{   public Character _movement;
    
  

    public Control(Character m)
   
    {
        _movement = m;
    }

    
    public void AUpdate()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        if (v != 0 || h != 0)
        {
            _movement.Move(v, h);
       
            
        
          
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
          //_movement.Jump();

        
        }
        
    }
}
