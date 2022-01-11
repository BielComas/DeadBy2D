using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorScript : MonoBehaviour
{
    //Variables de moviment 
    private float velocity = 5f;

    //Variables de vida
    private int lifes = 2;

    //Es crida un cop per frame
    private void Update()
    {
        
    }

    //Funció que activen els altres scripts per treure-li vida al player
    public void TakeDamage(int damage)
    {
        lifes -= damage;

        if (lifes <= 0)
        {
            Die();
        }
    }
    private void RepairGen()
    {

    }
    private void Die()
    {

    }
    private void HideLocker()
    {

    }
}
