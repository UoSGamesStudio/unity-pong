using UnityEngine;

namespace ShefGDS
{
    [AddComponentMenu("Pong/Goal")]
    public class Goal : MonoBehaviour
    {
        [SerializeField] Player owningPlayer;
            
        [SerializeField] PlayerEvent onScore;

        void Reset()
        {
            onScore = new PlayerEvent();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            var ball = other.GetComponent<Ball>();
            if (!ball) return;
            
            // Goal
            onScore?.Invoke(owningPlayer);
        }
    }
}
