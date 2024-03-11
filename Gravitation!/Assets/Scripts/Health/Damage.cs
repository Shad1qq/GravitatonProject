using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Health{


public class Damage : MonoBehaviour
{
    public Health hp;
    public bool staysec;
    public string enemytag;
    void Start()
    {
        hp = GetComponent<Health>();
        hp = FindAnyObjectByType<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player") && staysec == false){
            if(enemytag == "Knight"){
                hp.hp -= 2;
                staysec = true;
                StartCoroutine(Stay());
                Debug.Log("Knight");
            }
            if(enemytag == "ArrowMan"){
                hp.hp -= 1;
                staysec = true;
                StartCoroutine(Stay());
                Debug.Log("AM");
            }
            
        }
    }

    IEnumerator Stay(){
        yield return new WaitForSeconds(1);
        staysec = false;
    }

}
}