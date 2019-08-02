using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESManager : MonoBehaviour
{
    public static bool serch = false;
    public static int randomAnswer,befoePoint;
    [SerializeField] private List<int> answer;
    // Start is called before the first frame update
    void Start()
    {
        answer = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        befoePoint = randomAnswer;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
