using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Boss : MonoBehaviour
{
    [SerializeField] private List<GameObject> toEscape;
    [SerializeField] private GameObject targetPoint;

    [SerializeField] private float moveSpeed;
    Rigidbody2D rigi;
    [SerializeField] private int direction, vector;
    Animator anim;
    [SerializeField] private bool noWalk = false;
    // Start is called before the first frame update
    void Start()
    {
        toEscape = new List<GameObject>();
        rigi = GetComponent<Rigidbody2D>();
        vector = 1;
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (noWalk == false)
        {
            Walk();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.gameObject.tag == "Player")
        {
            noWalk = true;
            GameObject target = collision.gameObject;
            Vector2 pPos = target.transform.position;
            Vector2 distance = new Vector2(pPos.x - transform.position.x, pPos.y - transform.position.y);
            rigi.velocity = new Vector2(distance.x * moveSpeed * -1, distance.y * moveSpeed * -1);

        }*/


        if (collision.gameObject.tag == "EscapeSenser")
        {
            toEscape.Add(collision.gameObject);
            direction = Random.Range(0, 3);
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            noWalk = true;
            GameObject target = collision.gameObject;
            Vector2 pPos = target.transform.position;
            Vector2 distance = new Vector2(pPos.x - transform.position.x, pPos.y - transform.position.y);
            rigi.velocity = new Vector2(distance.x * moveSpeed * -1, distance.y * moveSpeed * -1);

        }
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EscapeSenser")
        {
            toMove.Add(collision.gameObject);
            movePoint = Random.Range(0, toMove.Count);
        }
    }*/
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EscapeSenser")
        {
            toEscape.Remove(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            toEscape.Remove(collision.gameObject);
            noWalk = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "Enemy")
        {
            vector = vector * -1;
        }
    }
    void Walk()
    {
        //左
        if (direction == 0)
        {
            rigi.velocity = new Vector2(-1 * vector * moveSpeed, 0);
            if (vector == 1)
            {
                anim.SetInteger("Rotate", 3);
            }
            else
            {
                anim.SetInteger("Rotate", 2);
            }

        }
        //右
        else if (direction == 1)
        {
            rigi.velocity = new Vector2(1 * vector * moveSpeed, 0);
            if (vector == 1)
            {
                anim.SetInteger("Rotate", 2);
            }
            else
            {
                anim.SetInteger("Rotate", 3);
            }

        }
        //前
        else if (direction == 2)
        {
            rigi.velocity = new Vector2(0, -1 * vector * moveSpeed);
            if (vector == 1)
            {
                anim.SetInteger("Rotate", 1);
            }
            else
            {
                anim.SetInteger("Rotate", 4);
            }
        }
        //後ろ
        else if (direction == 3)
        {
            rigi.velocity = new Vector2(0, 1 * vector * moveSpeed);
            if (vector == 1)
            {
                anim.SetInteger("Rotate", 4);
            }
            else
            {
                anim.SetInteger("Rotate", 1);
            }
        }


    }
}
