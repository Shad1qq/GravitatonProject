using UnityEngine;
namespace Scripts.Health{
public class Apple : MonoBehaviour
{
    public Health hp;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.CompareTag("Player")){
            
            hp.hp += 1;
            Destroy(this.gameObject);
        }
    }
}
}