using UnityEngine;

namespace Scripts.Health
{
    

public class DeadlySpikes : MonoBehaviour
{
    private GameObject player;
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            player.SetActive(false);
        } 
    }

}
}