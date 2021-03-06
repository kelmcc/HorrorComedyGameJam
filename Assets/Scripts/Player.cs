using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads
{
	[RequireComponent(typeof(Rigidbody))]
	public class Player : MonoBehaviour
	{

		public float movementSpeed = 5f;

		public Rigidbody rb;
		public Animator animator;

		Vector3 inputMovement;

		public void Awake()
		{
			LevelManagerService.Instance.RegisterPlayer(this);
		}

		public void Update()
		{
			inputMovement.x = Input.GetAxisRaw("Horizontal");
			inputMovement.z = Input.GetAxisRaw("Vertical");

			animator.SetFloat("Horizontal", inputMovement.x);
			animator.SetFloat("Vertical", inputMovement.z);
			animator.SetFloat("Speed", inputMovement.sqrMagnitude);
		}

		public void FixedUpdate()
		{
			rb.MovePosition(rb.position + inputMovement * movementSpeed * Time.fixedDeltaTime);
		}

		public void FoundPickUp(PickUp pickUp)
		{
			LevelManagerService.Instance.FoundPickup();
		}

		private void GetPetted(HandAgent handAgent)
		{
			LevelManagerService.Instance.GetPetted(handAgent.TouchType);
			handAgent.Unload();
		}

		public void OnTriggerEnter(Collider other)
		{
			PickUp pickUp = other.gameObject.GetComponent<PickUp>();

			if (pickUp != null)
			{
				FoundPickUp(pickUp);
				pickUp.Unload();
			}
		}

		public void OnCollisionEnter(Collision collision)
		{

			HandAgent handAgent = collision.gameObject.GetComponent<HandAgent>();

			if (handAgent != null)
			{
				GetPetted(handAgent);
			}
		}
	}
}