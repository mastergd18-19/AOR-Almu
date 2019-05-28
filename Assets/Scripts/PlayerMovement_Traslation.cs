using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Traslation : MonoBehaviour
{
    public float speed;
    public bool moving;
    private Vector2 line0;
    private Vector2 line1;
    private Vector2 line2;
    private Vector2 line3;
    private Vector2 line4;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;

        //se indican los railes/lineas por las que irá la pelotita corriendo
        line0 = new Vector2(0, 0);
        line1 = new Vector2(-1.564f, 0.439f);
        line2 = new Vector2(-2.332f, 1.56f);
        line3 = new Vector2(1.522f, 0.552f);
        line4 = new Vector2(2.2f, 1.55f);
    }   

    // Update is called once per frame
    void Update()
    {
        Movement();
       this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
         
    }

    void Movement()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            
            MovLeft();
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           //transform.Translate(Vector3.right * speed * Time.deltaTime);
            MovRight();
        }
        

        //En caso de tener más movimiento de cámara (iz, drch, arriba y abajo) sería poner esto mismo cuatro veces, por dirección

    }

    void MovLeft()
    {
        switch (this.gameObject.GetComponent<Transform>().position.x)
        {

            case -2.332f: //line2
                break;
            case -1.564f: //line1
                this.gameObject.transform.SetPositionAndRotation(new Vector3(-2.332f, 1.56f, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            case 0: //line0
                this.gameObject.transform.SetPositionAndRotation(new Vector3(-1.564f, 0.439f, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            case 1.522f: //line3
                this.gameObject.transform.SetPositionAndRotation(new Vector3(0, 0, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            case 2.2f: //line4
                this.gameObject.transform.SetPositionAndRotation(new Vector3(2.2f, 1.55f, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            default:
                break;
        }

        

    }

    void MovRight()
    {

        switch (this.gameObject.GetComponent<Transform>().position.x)
        {

            case -2.332f: //line2
                this.gameObject.transform.SetPositionAndRotation(new Vector3(-1.564f, 0.439f, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            case -1.564f: //line1
                this.gameObject.transform.SetPositionAndRotation(new Vector3(0, 0, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            case 0: //line0
                this.gameObject.transform.SetPositionAndRotation(new Vector3(1.522f, 0.552f, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            case 1.522f: //line3
                this.gameObject.transform.SetPositionAndRotation(new Vector3(1.522f, 0.552f, this.gameObject.GetComponent<Transform>().position.z), Quaternion.identity);
                break;
            case 2.2f: //line4
                break;
            default:
                break;
        }

        




    }
}
