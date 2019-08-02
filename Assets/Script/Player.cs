using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    Rigidbody2D rigi;
    Animator anim;
    //[SerializeField] private bool canMove = false;
    public static bool p1Move;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(p1Move == true)
        {
            Move();
        }

    }

    void Move()
    {
        float moveVer = Input.GetAxisRaw("Vertical");
        float moveHor = Input.GetAxisRaw("Horizontal");

        rigi.velocity = new Vector2(moveHor * moveSpeed * Time.deltaTime, moveVer * moveSpeed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.A))
        {
            anim.SetInteger("Move", 4);
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            anim.SetInteger("Move", -4);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            anim.SetInteger("Move", 3);
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            anim.SetInteger("Move", -3);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetInteger("Move", 2);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("Move", -2);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetInteger("Move",1 );
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            anim.SetInteger("Move", -1);
        }
        /*if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetFloat("Move", 0);
        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy_Shitappa" || collision.gameObject.tag == "Enemy_Kanbu" || collision.gameObject.tag =="Enemy_Boss")
        {
            Destroy(collision.gameObject);
            if(collision.gameObject.tag == "Enemy_Shitappa")
            {
                PointManager.sPoint += 100;
            }
            else if(collision.gameObject.tag == "Enemy_Kanbu")
            {
                PointManager.kPoint += 10000;
            }
            else if(collision.gameObject.tag == "Enemy_Boss")
            {
                PointManager.bPoint += 1000000;
            }

        }
    }

}
