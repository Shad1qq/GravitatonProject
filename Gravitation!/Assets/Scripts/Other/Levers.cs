
using Scripts.Movement;
using UnityEngine;

namespace Scripts.Other{


public class Levers : MonoBehaviour
{
    [SerializeField] private GameObject tm;
    [SerializeField] private PlatformMovement ig;
    bool igEnabled = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            tm.SetActive(true);
        }
 
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(Input.GetKeyDown(KeyCode.E) & igEnabled == false){
            ig.enabled = false;
            igEnabled = true;
        }
        if(Input.GetKeyDown(KeyCode.E) & igEnabled == true){
            ig.enabled = true;
            igEnabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        tm.SetActive(false);
    }
}
}