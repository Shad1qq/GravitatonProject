using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Movement{


public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private float wt;
    public float swt;
    public Transform[] points;
    private int randomSpot;
    void Start()
    {
        swt = wt;
        
        randomSpot = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[randomSpot].transform.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, points[randomSpot].transform.position) < 0.2f){
            if(wt >= 0){
                randomSpot = Random.Range(0, points.Length);
                wt = swt;
            }else{
                wt -= Time.deltaTime;
            }

        }
    }


}
}