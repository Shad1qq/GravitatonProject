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
        switch(heal.hp){
            case 4:
                spriteRenderers[spriteRenderers.Length - 1].sprite = sprite1;
                break;
        }
        
    }
}

}