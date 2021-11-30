    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   [SerializeField] float steerspeed = 200f;
    [SerializeField] float movespeed = 30f;
    [SerializeField] float slowmovespeed = 15f;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
        {   
            //if(other.tag=="Speed up")
            //movespeed+=10;
            if(other.tag=="Speed down")
            {Debug.Log("Speed down");
                movespeed=slowmovespeed;}

        }
    void OnTriggerExit2D(Collider2D other)
        {
            if(other.tag=="Speed down")
            {Debug.Log("Speed back");
            movespeed=30f;}
        }

    void Update()
    {  
        

        float steeramount = -Input.GetAxis("Horizontal")* steerspeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Rotate(0,0, steeramount );
        transform.Translate(0,moveamount,0);

        
        
    }
}
