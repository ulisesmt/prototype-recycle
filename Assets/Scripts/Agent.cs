using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public abstract class Agent : MonoBehaviour
{

    public float Speed = 3;

    public virtual void MoveTo() { }

}
