using UnityEngine;

namespace Scripts.GravitationFeatures
{
    


public class ItemGravitation : MonoBehaviour
{
    public Rigidbody2D[] rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D[]>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            for (int i = 0; i < rb.Length; i++)
            {
                rb[i].gravityScale *= -1;
            }
        }
    }
}
}