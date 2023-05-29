using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgCtrl : MonoBehaviour
{
    [SerializeField] private GameObject Bg;
    [SerializeField] private float speed;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
        Bg.transform.Translate(Vector3.left*speed*Time.deltaTime);
        speed += 1f * Time.deltaTime;
    }
}
