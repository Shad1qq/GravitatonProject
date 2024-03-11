using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Health{


public class Health : MonoBehaviour
{
    [Tooltip("Health")]
    [Range(0, 5)] public int hp;
    [Range(0, 5)] public int maxhp;
    void Start()
    {
        hp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        if(hp > 5){
            hp = maxhp;
        }
         if(hp <= 0){
            YouDead();
        }
    }
    void YouDead(){
        Destroy(this.gameObject);
    }
}
}