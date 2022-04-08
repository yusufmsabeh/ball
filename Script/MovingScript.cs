using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{

    private GameObject GameManager;


    private float forwardSpeed ;
    private Touch touch;
    private float deltaX;
    private Rigidbody2D rb;
    private float Forwardspeed;
  
    private float Speed;
    private float topSpeed;

    public GameObject ScorePanel;
    public GameObject ScoreText;
    public int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Speed = 0.5f;
        Forwardspeed  = 0.4f;
        GameManager = GameObject.FindWithTag("GameManager");
        topSpeed = 8;
        gameObject.GetComponent<SpriteRenderer>().sprite = GameManager.GetComponent<GameManager>().CuruentSkin;
    }

    // Update is called once per frame
    void Update()
    {

       

       
        
    }

    private void FixedUpdate()
    {

        MovingForward();

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
          // Vector2 touchPos = new Vector2();
            if (touch.phase == TouchPhase.Began)
            {
                deltaX = touchPos.x ;
            }
            else if (touch.phase == TouchPhase.Moved)

            {
                //transform.position = new Vector2((Mathf.Clamp (touchPos.x - deltaX) + transform.position.x * Speed), -2.7f, 2.7f, transform.position.y);

                transform.position = new Vector2(Mathf.Clamp(((touchPos.x - deltaX) + transform.position.x) * Speed,-2.7f,2.7f), transform.position.y) ;
                //transform.position = new Vector2((touchPos.x - deltaX )* Speed, transform.position.y);

               // rb.MovePosition(new Vector2(touchPos.x - deltaX, transform.position.y));
                //rb.MovePosition(new Vector2( Mathf.Clamp(touchPos.x - (deltaX * Time.deltaTime),-2.7f,2.7f) ,transform.position.y));
            }
            


        }
    }
        
    private void MovingForward()
    {

        rb.AddForce(transform.up * Forwardspeed);
        if (rb.velocity.magnitude > topSpeed)
            rb.velocity = rb.velocity.normalized * topSpeed;
       

    }

    private void OnCollisionEnter2D
       (Collision2D collision)
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        if (collision.collider.tag == "Enemy")
        {
            
            GameManager.GetComponent<GameManager>().KillPlayer();
            Destroy(gameObject);

        }
    }

    public void UpdateScore()
    {
        Score += 1;
        ScoreText.GetComponent<UnityEngine.UI.Text>().text = Score.ToString();

    }
   
}
