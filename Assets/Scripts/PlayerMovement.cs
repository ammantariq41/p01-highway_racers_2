using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public TextMeshProUGUI timerText;

    //coin collection
    public static int numberOfCoins;
    public Text coinsText;



    [SerializeField] float movementSpeed = 5f;
    public float jumpForce = 4f;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public Transform target;
    public AudioSource audioSource;
    public float speedIncrease = 50f;
    public float speedDecrease = 40f;
    public static PlayerMovement bikesnd;
    public float bikeSpeed = 10f;
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
        numberOfCoins = 0;    
    }

    // Update is called once per frame put its contents into a funciton (moveRight, moveLeft etc)
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // camelCase as this is variable
        float verticalInput = Input.GetAxis("Vertical"); // camelCase as this is variable

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            bikeSpeed += speedIncrease;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            if(bikeSpeed>10)
            {
                bikeSpeed -= speedDecrease;
                bikeSpeed = Mathf.Max(bikeSpeed, 0f);
            }
        }

        // if (Input.GetKey(KeyCode.LeftArrow)) {
        //     transform.Translate(Vector3.back * bikeSpeed * Time.deltaTime);
        // }
        // else if (Input.GetKey(KeyCode.RightArrow)) {
        //     transform.Translate(Vector3.forward * bikeSpeed * Time.deltaTime);
        // }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            //var step = speed * Time.deltaTime;
            float angle = Mathf.LerpAngle(transform.eulerAngles.x, 45, Time.deltaTime*rotationSpeed);
            transform.localEulerAngles = new Vector3(angle, 90, 0);
            //transform.localEulerAngles = new Vector3(Mathf.ler45, 90, 0);

            //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            float angle = Mathf.LerpAngle(transform.eulerAngles.x, -45, Time.deltaTime * rotationSpeed);
            transform.localEulerAngles = new Vector3(angle, 90, 0);
            //var step = speed * Time.deltaTime;

            //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        }
        
        transform.Translate(Vector3.left * bikeSpeed * Time.deltaTime);



        // rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        // transform.Translate(Vector3.left * currSpeed * Time.deltaTime);

        
        // Increase bike speed by 0.1 every second
        // bikeSpeed += 0.1f * Time.deltaTime;

        // if(Input.GetButtonDown("Jump"))
        // {
        //     rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        // }
        // if (Input.GetKey(KeyCode.RightArrow))
        // {

        //     //var step = speed * Time.deltaTime;
        //     float angle = Mathf.LerpAngle(transform.eulerAngles.x, 45, Time.deltaTime*rotationSpeed);
        //     transform.localEulerAngles = new Vector3(angle, 90, 0);
        //     //transform.localEulerAngles = new Vector3(Mathf.ler45, 90, 0);

        //     //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        // }
        // else if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     float angle = Mathf.LerpAngle(transform.eulerAngles.x, -45, Time.deltaTime * rotationSpeed);
        //     transform.localEulerAngles = new Vector3(angle, 90, 0);
        //     //var step = speed * Time.deltaTime;

        //     //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        // }
        // else
        // {
        //     float angle = Mathf.LerpAngle(transform.eulerAngles.x, 0, Time.deltaTime * rotationSpeed);
        //     transform.localEulerAngles = new Vector3(angle, 90, 0);

        // }




        /*

        if(Input.GetKeyDown("Up")) 
        {
            // rear_tyre.rotation = new Vector3(0,0,1);
            transform.Rotate(Vector3.up * 10 * Time.deltaTime);
        }

        */
        //coin collection
        coinsText.text = "Coins: " + numberOfCoins;


    }

    /*

    void FixedUpdate()
    {
        rb.AddForce(0, 0, 5f * speed, ForceMode.Impulse);
    }

    */

    void OnTriggerEnter(Collider collision)
	{
        if (!collision.gameObject.CompareTag("Coin"))
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

    

    //float XaxisRotation = Input.GetAxis("Horizontal") * speed;
    //XaxisRotation = Mathf.Clamp(XaxisRotation.x, -45, 0);






    //var rot = transform.localEulerAngles;
    //rot.x = rotation;
    //transform.localEulerAngles = rot;

    //if (Input.GetKey("a"))
    //    rotation -= speed * Time.deltaTime;


}
