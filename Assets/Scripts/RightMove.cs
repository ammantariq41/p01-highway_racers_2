using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    Rigidbody rb;
    public GameObject player;
    public float speed = 3;
    public float rotationSpeed = 5;
    bool isPressed = false;
    public float force = 3f;
    float duration = 2f;



    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isPressed)
        {

            rb.AddForce(2f * force, 0, 0, ForceMode.Impulse);
            float angle = Mathf.LerpAngle(player.transform.eulerAngles.x, 45, Time.deltaTime * rotationSpeed);
            player.transform.localEulerAngles = new Vector3(angle, 90, 0);



            ////player.transform.Translate(0,0, -force * Time.deltaTime);
            //rb.MovePosition(player.transform.position + Vector3.left * force*Time.deltaTime);
            //float angle = Mathf.LerpAngle(player.transform.eulerAngles.x, -45, Time.deltaTime * rotationSpeed);
            //player.transform.localEulerAngles = new Vector3(angle, 90, 0);

        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        float angle = Mathf.LerpAngle(player.transform.eulerAngles.x, 0, Time.deltaTime * rotationSpeed);
        player.transform.localEulerAngles = new Vector3(angle, 90, 0);
    }


    //private void FixedUpdate()
    //{
    //    rb.velocity = new Vector3(horizontalMove * Time.deltaTime, rb.velocity.y, verticalMove * Time.deltaTime);
    //}

}
