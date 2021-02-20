using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarFaceTarget : MonoBehaviour
{
    public Transform target;
    
    void LateUpdate() {
        transform.LookAt(transform.position + target.forward);
    }
}
