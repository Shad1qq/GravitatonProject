using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Scripts.Movement{


public class GravitationSwapping : MonoBehaviour
{

    public bool OnGrounded;
    public bool Swapper = false;
    public Transform GC;
    public float checkRadius;
    public LayerMask Ground;
    bool top;
    public Transform playertransf;
    public PlayerMovement rb;
    void Start()
    {
        rb = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        GravitationSwap();
        CheckGround();
    }

    void GravitationSwap(){
        if(Input.GetButtonDown("Fire1") && OnGrounded == true | Swapper == true){
            rb._rb.gravityScale *= -1;
            Rotate();
            
        }
        
    }
    void Rotate(){
        if(top == false){
            transform.eulerAngles = new Vector3(0,0,180);

        }
        else{
            transform.eulerAngles = Vector3.zero;
        }
        top = !top;
    }
    void CheckGround(){
        OnGrounded = Physics2D.OverlapCircle(GC.position, checkRadius, Ground);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Swapper")){
            Swapper = true;
        }
        else{
            Swapper = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("Swapper")){
            Swapper = false;
        }
    }
}
}