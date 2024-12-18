using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject[] animals;
    GameObject currentAnimal;

    bool LetItGo = false;
    // Start is called before the first frame update
    void Start()
    {
        currentAnimal = Instantiate(animals[0]);
        currentAnimal.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //2.SpawnAnimal
        if(Input.GetKeyDown(KeyCode.F))
        {
            int index = Random.Range(0, animals.Length);
            currentAnimal = Instantiate(animals[index]);
            currentAnimal.transform.position = transform.position;

            //currentAnimal.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
            currentAnimal.GetComponent<Rigidbody2D>().simulated = false;
            LetItGo = false;
        }
        
        //1.Spawner Movement 
        float movement = 0.5f;
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("MoveLeft");
            Vector3 spawnerPos = transform.position;
            spawnerPos.x += movement * (-1);
            transform.position = spawnerPos;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("MoveReft");
            Vector3 spawnerPos = transform.position;
            spawnerPos.x += movement * (1);
            transform.position = spawnerPos;

        }
           
        //3.Animal Follow
        if(currentAnimal != null && LetItGo == false)
        {
            currentAnimal.transform.position = transform.position;
        }

        //4.Let it Go
        if(currentAnimal != null && Input.GetKeyDown(KeyCode.Space))
        {
            LetItGo = true;
            //currentAnimal.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
            currentAnimal.GetComponent<Rigidbody2D>().simulated = true ;
        }
    }
}
