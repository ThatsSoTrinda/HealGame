using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    [SerializeField] int damage = 10;
    [SerializeField] float attackSpeed = 1.0f;
    [SerializeField] GameObject target;
    bool canAttack = false;
    float attackTimer;

    // Start is called before the first frame update
    void Start()
    {
        SetAttackTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (canAttack == false) {
            if (attackTimer > 0) {
                attackTimer -= Time.deltaTime;
            } else if (attackTimer <= 0) {
                canAttack = true;
            }
        }

        if (canAttack) {
            SetAttackTimer();

            HealthManager hm = target.GetComponent<HealthManager>();
            if (hm) {
                hm.TakeDamage(damage);
            }
        }
    }

    void SetAttackTimer() {
        canAttack = false;
        attackTimer = attackSpeed;
    }
}
