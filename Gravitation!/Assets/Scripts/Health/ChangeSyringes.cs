using UnityEngine;
using UnityEngine.UI;


namespace Scripts.Health{



public class ChangeSyringes : MonoBehaviour
{
    [SerializeField] private Sprite sprite1;
    public Health heal;
    [SerializeField] private Image[] spriteRenderers;
    void Start()
    {
        heal = GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(heal.hp <= 4){
            spriteRenderers[4].sprite = sprite1;
        }
        if(heal.hp <= 3){
            spriteRenderers[3].sprite = sprite1;
        }
        if(heal.hp <= 2){
            spriteRenderers[2].sprite = sprite1;
        }
        if(heal.hp <= 1){
            spriteRenderers[1].sprite = sprite1;
        }
        if(heal.hp <= 0){
            spriteRenderers[0].sprite = sprite1;
        }        
    }
}

}