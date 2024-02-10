using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class playerController : MonoBehaviour
{

    public float speed = 0;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    public int count;
    private float movementX;
    private float movementY;
    public GameObject winTextObject;
    public GameObject door;
    private AudioSource sfx;
    public GameObject Enemy;
    

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
        door.SetActive(true);
        sfx = GetComponent<AudioSource>();

    }

    void Update() {
        
        
    
    }



    void OnMove(InputValue movementValue) {
        
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void SetCountText() {
        countText.text = "Count: " + count.ToString();
        if (count >= 10) {
            winTextObject.SetActive(true);
        }
    }

    

    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    // source: https://www.youtube.com/shorts/2NsZv91lMPY
        if(Input.GetButtonDown("Jump")) {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }



    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            sfx.Play();
            SetCountText();
        }
        if (count == 6) {
            door.SetActive(false);
        }
        if (count == 4) {
            Enemy.SetActive(false);
        }
        

       
    }

    
    

   
}
