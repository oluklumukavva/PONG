using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player 1 - left player - movements 
        float verticalInput1 = Input.GetAxis("Player1");
        
        if (player1.transform.position.y < -3.9 && verticalInput1 < 0)
        {
            verticalInput1 = 0;

        }
        else if (player1.transform.position.y > 3.9 && verticalInput1 > 0)
        {
            verticalInput1 = 0;
        }
        
        Vector3 direction1 = new Vector3(0, verticalInput1, 0);
        player1.transform.Translate(Time.deltaTime * _speed * direction1);
        
        
        
        // Player 2 - right player - movements 
        float verticalInput2 = Input.GetAxis("Player2");
        
        if (player2.transform.position.y < -3.9 && verticalInput2 < 0)
        {
            verticalInput2 = 0;

        }
        else if (player2.transform.position.y > 3.9 && verticalInput2 > 0)
        {
            verticalInput2 = 0;
        }
        
        
        Vector3 direction2 = new Vector3(0, verticalInput2, 0);
        player2.transform.Translate(Time.deltaTime * _speed * direction2);
        
    }
}
