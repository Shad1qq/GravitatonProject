using UnityEngine;
using UnityEngine.UI;


namespace Scripts.Health{



public class ChangeSyringes : MonoBehaviour
{
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Animator anims;
    [SerializeField] private Animator anims1;
    [SerializeField] private Animator anims2;
    [SerializeField] private Animator anims3;
    [SerializeField] private Animator anims4;
    public Health heal;
    
    [SerializeField] private SpriteRenderer[] spriteRenderers;
    void Start()
    {
        heal = GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(heal.hp <= 4){
            spriteRenderers[4].sprite = sprite1;
            anims.SetBool("StartFill1", true);
        }
        if(heal.hp <= 3){
            spriteRenderers[3].sprite = sprite1;
            anims1.SetBool("StartFill2", true);
        }
        if(heal.hp <= 2){
            spriteRenderers[2].sprite = sprite1;
            anims2.SetBool("StartFill3", true);
        }
        if(heal.hp <= 1){
            spriteRenderers[1].sprite = sprite1;
            anims3.SetBool("StartFill4", true);
        }
        if(heal.hp <= 0){
            spriteRenderers[0].sprite = sprite1;
            anims4.SetBool("StartFill5", true);
        }        
    }
}

}