using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int scoreNum;
    private PlatformCtrl scoreSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        scoreText.text = "Score : " + scoreNum;
        scoreSpeed = gameObject.GetComponent<PlatformCtrl>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreNum += (int)scoreSpeed.speed;
        scoreText.text = "Score" + scoreNum / 500;
    }

}
