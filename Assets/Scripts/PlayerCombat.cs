using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    // variavel que define em que estado do ataque o jogador está
    int combo = 0;

    //varivel que define a quantidade total de ataque 
    int comboTotal = 3;

    // varivel que controla se o personagem pode atacar
    bool cantAttack = true;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        animator.SetInteger("comboPunch", combo);

        if (InputController.InputActionPrincipal) 
        {
            PunchsCombo();
        }
    }
    void PunchsCombo() 
    {
        combo++;
        animator.SetInteger("comboPunch", combo);
        if (combo > 3) 
        {
            combo = 0;
            Thread.Sleep(3000);
        }
    }
}
