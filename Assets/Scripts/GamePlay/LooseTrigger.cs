using UnityEngine;

namespace GamePlay
{
    public class LooseTrigger : MonoBehaviour
    {
        private const string _ballTag = "Ball";

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.CompareTag(_ballTag))
                GameEvents.ResetGame?.Invoke();
        }
    }
}
