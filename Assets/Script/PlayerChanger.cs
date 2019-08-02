using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChanger : MonoBehaviour
{
    [SerializeField] private GameObject camera1,camera2;
    public static bool playerChanger = true;

    // Start is called before the first frame update
    void Start()
    {
        Player.p1Move = true;
        Player2.p2Move = false;
        camera1.SetActive(true);
        camera2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerChange();
    }

    void PlayerChange()
    {
        if(!playerChanger && Input.GetKeyDown(KeyCode.Space))
        {
            playerChanger = true;
            Player.p1Move = true;
            Player2.p2Move = false;
            camera1.SetActive(true);
            camera2.SetActive(false);
            
        }
        else if(playerChanger == true && Input.GetKeyDown(KeyCode.Space))
        {
            playerChanger = false;
            Player.p1Move = false;
            Player2.p2Move = true;
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }
}
