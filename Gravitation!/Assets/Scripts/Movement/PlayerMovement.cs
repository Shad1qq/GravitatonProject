using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Movement{


public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody2D _rb;
    
    
    [Range(0f, 15f)] [SerializeField] private float _speed; 

    [SerializeField] private Vector2 _direction;
    
    [SerializeField] private SpriteRenderer playerrend;

    private void Awake()   
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = (Input.GetAxis("Horizontal"));
        Walk();
        

        
    }

    void Walk(){
        _rb.velocity = new Vector2(_direction.x * _speed, _rb.velocity.y);
    }


}
}