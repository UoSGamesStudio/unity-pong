using System;
using UnityEngine;
using UnityEngine.Events;

namespace ShefGDS
{
    [AddComponentMenu("Pong/Goal")]
    public class Goal : MonoBehaviour
    {
        [SerializeField] PlayerData owningPlayerData;
            
        [SerializeField] PlayerEvent onScore;


        Action<PlayerData> _onScoreAction;
        
        public event Action<PlayerData> OnScoreEvent
        {
            add => _onScoreAction += value;
            remove => _onScoreAction -= value;
        }
        

        void Reset()
        {
            onScore = new PlayerEvent();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            var ball = other.GetComponent<Ball>();
            if (!ball) return;
            
            // Goal
            InvokeScoreEvent();
        }

        void InvokeScoreEvent()
        {
            _onScoreAction?.Invoke(owningPlayerData);
            onScore.Invoke(owningPlayerData);
        }

        public void SetPlayerData(PlayerData playerData) => owningPlayerData ??= playerData;
    }
}
