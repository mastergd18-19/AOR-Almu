using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFlow : MonoBehaviour
{
    public float speed;
    public bool moving;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
       this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Movement()
    {
       
    }
}
