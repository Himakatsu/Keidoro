using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float lLimit, rLimit, uLimit, dLimit;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        CameraMove();
        //左上
        
        //左下

        //右上

        //右下

        //上

        //右

        //左

        //下


    }
    void CameraMove()
    {
        //Vector3 nowPos = transform.position;
        Vector2 playerPos = player.transform.position;
        //左上
        if(playerPos.y > uLimit && playerPos.x < lLimit)
        {
            transform.position = new Vector3(lLimit, uLimit, -10f);
        }
        //左下
        else if(playerPos.y < dLimit && playerPos.x <lLimit)
        {
            transform.position = new Vector3(lLimit, dLimit, -10f);
        }
        //右上
        else if(playerPos.y > uLimit && playerPos.x > rLimit)
        {
            transform.position = new Vector3(rLimit, uLimit, -10f);
        }
        //右下
        else if(playerPos.y < dLimit && playerPos.x > rLimit)
        {
            transform.position = new Vector3(rLimit, dLimit, -10f);
        }
        //上
        else if(playerPos.y > uLimit)
        {
            transform.position = new Vector3(playerPos.x, uLimit, -10f);
        }
        //右
        else if(playerPos.x > rLimit)
        {
            transform.position = new Vector3(rLimit, playerPos.y, -10f); 
        }

        //左
        else if(playerPos.x < lLimit)
        {
            transform.position = new Vector3(lLimit, playerPos.y, -10f);
        }
        //下
        else if(playerPos.y < dLimit)
        {
            transform.position = new Vector3(playerPos.x, dLimit, -10f);
        }
        //その他
        else
        {
            transform.position = new Vector3(playerPos.x, playerPos.y, -10f);
        }
    }
}
