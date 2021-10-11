using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveController : MonoBehaviour
{
	[SerializeField] private int currentObjectiveIndex;

	[SerializeField] private List<Objective> objectives = new List<Objective>();

	void OnEnable()
	{
		foreach (Objective obj in objectives)
		{
			obj.onObjectiveCompleted.AddListener(ObjectiveCompleted);
		}
	}

	void OnDisable()
	{
		foreach (Objective obj in objectives)
		{
			obj.onObjectiveCompleted.RemoveListener(ObjectiveCompleted);
		}
	}

	void Start()
	{
		objectives[currentObjectiveIndex].StartObjective();
	}

	void ObjectiveCompleted(Objective obj)
	{
		int index = objectives.IndexOf(obj);

		if (index != currentObjectiveIndex)
			return;

		currentObjectiveIndex = ++index;

		if (currentObjectiveIndex < objectives.Count)
			objectives[currentObjectiveIndex].StartObjective();
	}
}
