using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    [SerializeField] private GameObject pointText;
    public static int sPoint, kPoint, bPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text();
    }
    void Text()
    {
        Text pText = pointText.GetComponent<Text>();
        int allPoint = sPoint + kPoint + bPoint;
        pText.text = "ポイント：" + allPoint;
    }
}
