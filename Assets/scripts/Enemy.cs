using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Velocidade=2;
    private Rigidbody2D rig;
    public Transform FloorCheck;
    public LayerMask Floor;
    public bool Grounded;

    public Transform WallCheck;
    public LayerMask Wall;
    public bool Walled;


    // Start is called before the first frame update
    void Start()
    {
      rig = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Grounded=Physics2D.OverlapCircle(FloorCheck.position,0.1f,Floor);
        Walled=Physics2D.OverlapCircle(WallCheck.position,0.1f,Wall);
        if(!Grounded||Walled)
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x*-1,1,1);
        }
        if(gameObject.transform.localScale.x<1)
        {
          rig.velocity= new Vector2(Velocidade*-1,rig.velocity.y);
        }
        else
        {
          rig.velocity= new Vector2(Velocidade,rig.velocity.y);
        }
    }
}
