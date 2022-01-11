using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    //Control del procés del generador
    private float lifes;
    private bool isBroken;
    
    //metode que comprova que tots els slots del generador estan ocupats
    private void isFull()
    {

    }
    //Metode que s'activa un cop el generador esta fet.
    private void DiscountGen()
    {
      

        /* Es crearà un so un cop s'executi per anunciar els jugadors
         * que s'ha finalitzat un generador, i seguidament s'activarà la
         * funció CheckGens() del ExitGateScript.
         */
    }
    //Funció que activa el Killer quan trenca el generador.
    public void TakeDamage(int damage)
    {

    }
}
