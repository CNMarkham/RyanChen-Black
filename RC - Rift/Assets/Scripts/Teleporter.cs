using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform destination;
    //returns destination
    public Transform GetDestination()
    {
        return destination;
    }
}
