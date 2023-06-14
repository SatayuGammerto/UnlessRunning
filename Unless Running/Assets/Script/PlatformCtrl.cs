using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCtrl : MonoBehaviour
{
    [SerializeField] private GameObject patternMove;
    [SerializeField] private GameObject[] patternRandom;
    [SerializeField] private float speed;
    [SerializeField] private float speedAcc;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
        
        patternMove.transform.Translate(Vector3.left*speed*Time.deltaTime);
        speed += speedAcc * Time.deltaTime;
    }

}
