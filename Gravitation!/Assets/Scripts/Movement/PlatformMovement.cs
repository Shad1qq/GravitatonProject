
using UnityEngine;
namespace Scripts.Movement
{
    

public class PlatformMovement : MonoBehaviour
{
    public float pspeed;
    private float pwt;
    public float pswt;
    public Transform[] plpoints;
    private int randomSpot;
    void Start()
    {
        pswt = pwt;
        
        randomSpot = Random.Range(0, plpoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, plpoints[randomSpot].transform.position, pspeed * Time.deltaTime);
        if(Vector2.Distance(transform.position, plpoints[randomSpot].transform.position) < 0.2f){
            if(pwt >= 0){
                randomSpot = Random.Range(0, plpoints.Length);
                pwt = pswt;
            }else{
                pwt -= Time.deltaTime;
            }

        }
    }

}
}