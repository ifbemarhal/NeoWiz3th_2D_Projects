using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tracker_Enemy : MonoBehaviour
{
    public float speed=3.0f;     // 용병들에 따라 이속이 다르게 세팅하고 싶은데.. 일단은 따라 한 다음에 방법을 찾아보자
    public float health = 100.0f;
    
    public Rigidbody2D _target;

    bool isLive;
    public Rigidbody2D _rigid;
    SpriteRenderer _spriter;

    void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _spriter = GetComponent<SpriteRenderer>();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLive)
        {
            return;
        }
        Vector2 _dirVec = _target.position - _rigid.position;
        Vector2 _nextVec = _dirVec.normalized * speed * Time.fixedDeltaTime;
        _rigid.MovePosition(_rigid.position + _nextVec);
        // _rigid.linearVelocity = Vector2.zero;
        
    }


    private void LateUpdate()
    {
        _spriter.flipX = _target.position.x > _rigid.position.x;
    }

    public void OnServerInitialized()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Bullet"))
            return;
        
            health -= collision.GetComponent<Bullet>().damage;
        if (health > 0)
        {
            
        }
        else
        {
            Dead();
        }

    }

    void Dead()
    {
        Destroy(gameObject);
    }

}
