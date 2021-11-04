using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public class ObjectiveEvent : UnityEvent<Objective> { }

public enum ObjectiveState
{
    Inactive,
    Started,
    Completed
}

public class Objective : MonoBehaviour
{
	[SerializeField] float delay;

	[SerializeField] private bool startAutomatically;
	[SerializeField] private bool started;
	[SerializeField] private bool completed;

	public ObjectiveEvent onObjectiveStarted;
	public ObjectiveEvent onObjectiveCompleted;

	

	void Start()
	{
		if (startAutomatically == false)
			return;

		StartObjective();
	}

	public void StartObjective()
	{
		started = true;

		if (onObjectiveStarted != null)
			onObjectiveStarted.Invoke(this);
	}

	public void CompleteObjective()
	{
		if (started == false || completed == true)
			return;

		completed = true;

		StartCoroutine(DelayedComplete());
	}

	IEnumerator DelayedComplete()
	{
		yield return new WaitForSeconds(delay);

		if (onObjectiveCompleted != null)
			onObjectiveCompleted.Invoke(this);
	}
}
