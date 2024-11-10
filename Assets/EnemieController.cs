using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieController : MonoBehaviour
{
    public Sprite sprite1; 
    public Sprite sprite2;
    public float force;
    public float life;
    public enemigo tipoEnemigo; 
    private SpriteRenderer spriteRenderer; 
    public enum enemigo
    {
        enemigo1, 
        enemigo2  
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 

        CambiarSprite(); 
    }

    private void CambiarSprite()
    {
        switch (tipoEnemigo)
        {
            case enemigo.enemigo1:
                spriteRenderer.sprite = sprite1;
                force = 5;
                life = 10;
                break;
            case enemigo.enemigo2:
                spriteRenderer.sprite = sprite2;
                force = 15;
                life = 5;
                break;
        }
    }
}