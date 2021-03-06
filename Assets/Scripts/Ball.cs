using System;
using UnityEngine;

namespace ShefGDS
{
	[AddComponentMenu("Pong/Ball")]
    [RequireComponent(typeof(Rigidbody2D), typeof(CircleCollider2D))]
    public class Ball : MonoBehaviour
    {
	    [SerializeField, Range(0, 1)] float acceleration = 0.5f;
	    [SerializeField, Min(1)] float maxSpeed = 5;
	    
	    Rigidbody2D _rigidbody;

	    public float Speed => _rigidbody.velocity.magnitude;

	    void Awake()
	    {
		    _rigidbody = GetComponent<Rigidbody2D>();
		    _rigidbody.velocity = Vector2.one;
	    }

	    void Update()
	    {
		    var vel = _rigidbody.velocity;
		    _rigidbody.velocity = Vector2.MoveTowards(vel, vel.normalized * maxSpeed, acceleration);
	    }
	    
	    public void SetPosition(Vector2 position) => _rigidbody.position = position;

	    public void SetVelocity(Vector2 velocity) => _rigidbody.velocity = velocity;
    }
}
