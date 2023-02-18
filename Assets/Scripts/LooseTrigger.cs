using System;
using UnityEngine;

public class LooseTrigger : MonoBehaviour
{
    public static Action GameLoose;
    private const string _ballTag = "Ball";

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(_ballTag))
            GameLoose?.Invoke();
    }
}
