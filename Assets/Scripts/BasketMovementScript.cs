using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    public float leftBoundary, rightBoundry;
    public int points;

    private int score;
    public UnityEngine.UI.Text scoreText;

    private SceneHandler sceneHandler;

    // Start is called before the first frame update
    void Start()
    {
        sceneHandler = FindObjectOfType<SceneHandler>();
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

    private void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Healthy")
        {
            //Add points
            UpdateScore(points);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "Unhealthy")
        {
            //Minus points
            sceneHandler.LoseScene();
        }
    }

}
