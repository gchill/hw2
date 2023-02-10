using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class playercontrol : MonoBehaviour
{
    public  string change;
    public float speed = 5;
    public TextMeshProUGUI countText;
    public GameObject winTxtobject;
    public GameObject SceneMagnager;
    public TextMeshProUGUI pausetxt;

    private Rigidbody rb;
    private int count;
    private float movementx;
    private float movementy;
    public bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        pausetxt.enabled = false;
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementx = movementVector.x;
        movementy = movementVector.y;
    }
    void SetCountText()
    {
        countText.text ="Count: "+ count.ToString();
        if(count >= 12)
        {
           SceneManager.LoadScene("end");
        }
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementx, 0.0f, movementy);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pickup"))
        {
        other.gameObject.SetActive(false);
        count = count + 1;
        SetCountText();
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            rb.isKinematic = true;
            pausetxt.enabled = true;
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            rb.isKinematic = false;
            pausetxt.enabled = false;
        }
    }
}
