using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delivery : MonoBehaviour
{   
    bool hasPackage;// initiliase to false
    int nopackdel;//initialise to 0
    [SerializeField] int destroydelay=0;

    [SerializeField] Color32 haspackcolor = new Color32 (1,1,1,1);
    [SerializeField] Color32 hasnopackcolor = new Color32 (1,1,1,1);    
    [SerializeField] Sprite newSprite;
    [SerializeField] Sprite oldSprite;  

    SpriteRenderer spriteRenderer;
    int eapple=0;

    void Start()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)  
    {
        Debug.Log("Crash");
    }
    void OnTriggerEnter2D(Collider2D other)
    {  
        if (other.tag =="Apple")
        {
            Debug.Log("Eaten");
            eapple++;
            Destroy(other.gameObject,destroydelay);
            if (eapple==11)
            {SceneManager.LoadScene(2);}
        }
        else 
        Debug.Log("WHee");
    }
}   

    