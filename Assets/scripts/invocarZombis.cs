using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocarZombis : MonoBehaviour
{
    public GameObject zombi;
    public float tiempo=0f;
 

  
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo > 10f)
        {
            crearEnemy();
            tiempo=0f;
        }                 
     
    }
    void crearEnemy(){
            var position = new Vector2(transform.position.x , transform.position.y);
            Instantiate(zombi, position, zombi.transform.rotation);
    }
}
