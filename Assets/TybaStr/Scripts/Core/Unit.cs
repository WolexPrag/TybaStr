
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] private Fraction _belong;
    public float Health { get; set; }
}

