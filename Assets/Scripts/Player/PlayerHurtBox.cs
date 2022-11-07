using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurtBox : Checker
{
    private PlayerController player;
    private Vector2 forceVector;
    private bool isRightOfPlayer;
    private void Start()
    {
        player = obj.GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemiesAttack"))
        {
            int dmg = other.GetComponent<EnemiesAttack>().dmg; //use later
            forceVector = other.GetComponent<EnemiesAttack>().ForceVector;
            isRightOfPlayer = (transform.position.x < PlayerController.Instance.transform.position.x);
            player.GetHit(forceVector, isRightOfPlayer);
        }
    }
}
