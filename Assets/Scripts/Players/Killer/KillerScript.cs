using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerScript : MonoBehaviour
{
    //Vector per controlar la direcció on vol caminar
    Vector2 direction;
    //Variable per controlar l'estat
    private State state;

    //Variables de moviment i físiques
    [SerializeField] private float velocity = 5f;
    private Rigidbody2D rb;

    // Es crida un cop al iniciar el joc
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private enum State
    {
        Normal,
        Attack,
        Mori,
    }
    // Es crida un cop per frame
    void Update()
    {
        switch (state)
        {
            case State.Normal:
                HandleMovement();
                break;
            case State.Attack:
                KillerAttack();
                break;
            case State.Mori:
                //F survivor
                break;
        }
    }
    // Es crida un cop per cada iteració del motor de físiques.
    
    private void HandleMovement()
    {
        float moveX = 0f;
        float moveY = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }

        Vector3 direction = new Vector2(moveX, moveY);
        transform.position += direction.normalized * velocity * Time.deltaTime; 

    }
    //Funció per trencar el generador.
    private void KickGen(int damage)
    {
        /* Si el Killer està dins del rang d'un generador que s'ha estat fent,
         * pot presionar espai per trencar-lo, el qual activa la funció 
         * TakeDamage() del generador golpejat.
         */
    }
    private void KillerAttack()
    {
        //si l'atac colisiona amb el player, activar el metode TakeDamage() del player.
    }
    private void CheckLocker()
    {
        //si està dins del rang d'una taquilla i presiona espai, obre la taquilla.
    }
    private void GrabSurvivor()
    {
        //agafa el survivor del terra.
    }
}
