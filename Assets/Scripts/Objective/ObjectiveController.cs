using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveController : MonoBehaviour
{
    [SerializeField] private int currentObjective;
    [SerializeField] private int currentObjectiveIndex;

    [SerializeField] private List<Objective> objectives = new List<Objective>();

    private ObjectiveEvent onObjectiveStarted = new ObjectiveEvent();
    public ObjectiveEvent OnObjectiveStarted { get { return onObjectiveStarted; } }

    private ObjectiveEvent onObjectiveCompleted = new ObjectiveEvent();
    public ObjectiveEvent OnObjectiveCompleted { get { return onObjectiveCompleted; } }

    void Start()
    {
        StartCoroutine(StartObjective(objectives[0]));
    }

    void OnEnable()
    {
        foreach (Objective obj in objectives)
        {
            if (obj != null)
            {
                obj.Init(this);
            }
        }
    }

    void OnDisable()
    {
        foreach (Objective obj in objectives)
        {
            if (obj != null)
            {

            }
        }
    }

    void CompleteObjective()
    {
        if (onObjectiveCompleted != null)
            onObjectiveCompleted.Invoke(objectives[currentObjectiveIndex]);

        currentObjectiveIndex++;

        if (currentObjectiveIndex < objectives.Count)
            StartCoroutine(StartObjective(objectives[currentObjectiveIndex]));
    }
    IEnumerator StartObjective(Objective objective)
    {
        if (objective == null)
            yield break;


        if (onObjectiveStarted != null)
            onObjectiveStarted.Invoke(objective);
    }
}
