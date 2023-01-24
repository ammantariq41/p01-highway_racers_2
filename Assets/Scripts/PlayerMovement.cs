using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public TextMeshProUGUI timerText;


    [SerializeField] float movementSpeed = 5f;
    public float jumpForce = 4f;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public Transform target;
    public AudioSource audioSource;

    public static PlayerMovement bikesnd;

    public float bikeMaxSpeed = 120f; //km per hour
    public float currSpeed = 30f;
    public float bikeCurrentSpeed = 0f;
    int bike_lives = 3;


    // Start is called before the first frame update
    void Start()
    {
        bikesnd = this;
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        //currSpeed += Time.deltaTime * 1.1f;

    }

    // Update is called once per frame put its contents into a funciton (moveRight, moveLeft etc)
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // camelCase as this is variable
        float verticalInput = Input.GetAxis("Vertical"); // camelCase as this is variable

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        transform.Translate(Vector3.left * currSpeed * Time.deltaTime);


        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            float angle = Mathf.LerpAngle(transform.eulerAngles.x, 45, Time.deltaTime * rotationSpeed);
            transform.localEulerAngles = new Vector3(angle, 90, 0);
            ;
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            float angle = Mathf.LerpAngle(transform.eulerAngles.x, -45, Time.deltaTime * rotationSpeed);
            transform.localEulerAngles = new Vector3(angle, 90, 0);

            //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        }
        else
        {
            float angle = Mathf.LerpAngle(transform.eulerAngles.x, 0, Time.deltaTime * rotationSpeed);
            transform.localEulerAngles = new Vector3(angle, 90, 0);

        }



    }



    void OnTriggerEnter(Collider collision)
    {
        audioSource.Play();
        Debug.Log(collision.gameObject.name);
        bike_lives--;
        if (bike_lives == 0)
        {
            SceneManager.LoadScene(2);
        }

    }



}

//currSpeed = (rb.velocity.magnitude * 3.6f) / bikeMaxSpeed;
//if(currSpeed > 0.9f)
//  bikeCurrentSpeed = 0.9f;
//else
//  bikeCurrentSpeed = currSpeed;