using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class SpeedPU : PPowerUp
    {
        public float speed;

        public override void Get(PPlayer player)
        {
            player.PSpeedUp(speed);
            Destroy(gameObject);
        }
    }
