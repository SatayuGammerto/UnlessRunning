using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCtrl : MonoBehaviour
{
    [SerializeField] private PlayerCtrl playerMove;
    [SerializeField] private GameObject[] patternLvl;
    public float speed;
    [SerializeField] private float speedAcc;
    [Space(20)]

    [SerializeField] private float minWide;
    [SerializeField] private float mexWide;
    [SerializeField] private float minHigh;
    [SerializeField] private float mexHigh;

    bool hasPlatform = true;

    // Update is called once per frame
    private void Update()
    {
        playerMove.transform.Translate(Vector3.right*speed*Time.deltaTime);
        speed += speedAcc * Time.deltaTime;

        if (!hasPlatform)
        {
            SpawnPlatform();

            hasPlatform = true;
        }
      
    }

    public void SpawnPlatform()
    {
        var randomWide = Random.Range(minWide, mexWide);
        var randomHigh = Random.Range(minHigh, mexHigh);

        Instantiate(patternLvl[Random.Range(0,patternLvl.Length)], new Vector3(transform.position.x + randomWide, transform.position.y + randomHigh, 0), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SpawnChack"))
        {
            hasPlatform = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SpawnChack"))
        {
            hasPlatform = false;
        }
    }

}
