using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionArea : MonoBehaviour
{

    public UnityAction interact;

    private void OnTriggerStay(Collider other)
    {
        other.TryGetComponent<PlayerCharacter>(out var charact);
        if (charact == null) return;

        interact?.Invoke();
    }
}
