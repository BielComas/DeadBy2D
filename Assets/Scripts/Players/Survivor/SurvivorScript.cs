using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorScript : MonoBehaviour
{
    //Vector per controlar l'input i la direcció on es vol moure el jugador
    Vector2 direction;

    //variable per controlar els estats 
    private State state;

    //Variables de moviment i físiques
    private float velocity = 5f;
    private Rigidbody2D rb;

    //Variables de vida
    private int lifes = 2;

    //S'executa un cop iniciat el joc, va bé per inicialitzar objectes que necessites.
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //màquina d'estats del jugador survivor
    private enum State
    {
        Normal,
        Repairing,
        Die,
    }
    //Es crida un cop per frame
    private void Update()
    {
        switch (state)
        {
            
            case State.Normal:
                HandleMovement();
                break;
            case State.Repairing:
                RepairGen();
                break;
            case State.Die:
                PlayerDie();
                break;

        }
    }
    // Es crida per cada iteració del motor de físiques (es més exacte)
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * velocity * Time.deltaTime);
    }

    private void HandleMovement()
    {

        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    //Funció que activen els altres scripts per treure-li vida al player
    public void TakeDamage(int damage)
    {
        lifes -= damage;

        if (lifes <= 0)
        {
            PlayerDie();
        }
    }
    private void RepairGen()
    {

    }
    private void PlayerDie()
    {

    }
    private void HideLocker()
    {

    }
}
