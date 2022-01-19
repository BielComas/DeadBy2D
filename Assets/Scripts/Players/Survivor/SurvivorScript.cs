using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorScript : MonoBehaviour
{
    //Vector per controlar l'input i la direcci� on es vol moure el jugador
    Vector2 direction;

    //variable per controlar els estats 
    private State state;

    //Variables de moviment i f�siques
    private float velocity = 5f;
    private Rigidbody2D rb;

    //Variables de vida
    private int lifes = 2;

    //S'executa un cop iniciat el joc, va b� per inicialitzar objectes que necessites.
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //m�quina d'estats del jugador survivor
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
    // Es crida per cada iteraci� del motor de f�siques (es m�s exacte)
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction.normalized * velocity * Time.deltaTime);
    }

    private void HandleMovement()
    {

        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    //Funci� que activen els altres scripts per treure-li vida al player
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
