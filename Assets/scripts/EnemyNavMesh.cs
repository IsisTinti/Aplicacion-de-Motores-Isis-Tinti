using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EnemyNavMesh :PPlayer
{
   
        public Transform jugador;
        UnityEngine.AI.NavMeshAgent enemigo;
        private bool dentro = false;
 
    public Text _life;
        // Use this for initialization
        void Start()
        {
            enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
        Life = 5;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                dentro = true;
            Life -= 1;
            }
        Debug.Log(Life + " vidas");

        }
    

        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                dentro = false;
            
            }
        }
        // Update is called once per frame
        void Update()
        {

            if (!dentro)
            {
                enemigo.destination = jugador.position;
            }
            if (dentro)
            {
                enemigo.destination = this.transform.position;
            }
        _life.text = "vidas: " + Life;
        if (Life <= 0)
        {
            SceneManager.LoadScene(0);
        }
        }
      
}
