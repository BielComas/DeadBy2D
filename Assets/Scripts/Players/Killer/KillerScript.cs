using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerScript : MonoBehaviour
{
    //variables de velocitat
    private float velocity;


    // Es crida un cop per frame
    void Update()
    {
        
    }

    //Funci� per trencar el generador.
    private void KickGen(int damage)
    {
        /* Si el Killer est� dins del rang d'un generador que s'ha estat fent,
         * pot presionar espai per trencar-lo, el qual activa la funci� 
         * TakeDamage() del generador golpejat.
         */
    }
    private void Attack()
    {
        //si l'atac colisiona amb el player, activar el metode TakeDamage() del player.
    }
    private void CheckLocker()
    {
        //si est� dins del rang d'una taquilla i presiona espai, obre la taquilla.
    }
    private void GrabSurvivor()
    {
        //agafa el survivor del terra.
    }
}
