using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipemovescript : MonoBehaviour
{
    public float movespeed = 5;
    public float deadzone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadzone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
        transform.position += (Vector3.left*movespeed*Time.deltaTime);
        
    }
}
