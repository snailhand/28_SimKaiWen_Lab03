using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    public float leftBoundary, rightBoundry;
    public float healthyPoints, UnhealthyPoints;

    private int score;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBasket();
    }

    private void MoveBasket()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x < rightBoundry)
        {
            transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position = new Vector3(rightBoundry, transform.position.y, transform.position.z);
        }

        if (transform.position.x > leftBoundary)
        {
            transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Healthy")
        {
            //Add points

        }
        else if(collision.gameObject.tag == "Unhealthy")
        {
            //Minus points

        }
    }

}
