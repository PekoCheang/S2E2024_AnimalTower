using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCollect : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Something's Here");

        bool isAnimal = false;
        isAnimal = collision.gameObject.CompareTag("Animal");
        if (isAnimal == true)
        {
            Debug.Log("It's an Animal!!");
            Destroy(collision.gameObject);
            Debug.Log("Game Over!!");
        }

    }
    private void aaOnTriggerEnter2D(Collider2D collection)
    {
      

    }
}