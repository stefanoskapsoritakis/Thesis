using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public class ObjectiveEvent : UnityEvent<Objective> { }
[System.Serializable] public class ObjectiveProgressEvent : UnityEvent<float> { }

public enum ObjectiveState
{
    Inactive,
    Started,
    Completed
}

public class Objective : MonoBehaviour
{
    [SerializeField] private ObjectiveState objectiveState;

    private ObjectiveController objectiveController;
    private bool initialized;

    [SerializeField] private ObjectiveEvent onObjectiveStarted;
    public ObjectiveEvent OnObjectiveStarted { get { return onObjectiveStarted; } }

    [SerializeField] private ObjectiveEvent onObjectiveCompleted;
    public ObjectiveEvent OnObjectiveCompleted { get { return onObjectiveCompleted; } }

    public void Init(ObjectiveController controller)
    {
        initialized = true;
        objectiveController = controller;

        objectiveController.OnObjectiveStarted.AddListener(StartObjective);
        objectiveController.OnObjectiveCompleted.AddListener(CompleteObjective);
    }

    private void OnDestroy()
    {
        if (objectiveController == null)
            return;

        objectiveController.OnObjectiveStarted.RemoveListener(StartObjective);
        objectiveController.OnObjectiveCompleted.RemoveListener(CompleteObjective);
    }

    void StartObjective(Objective objective)
    {
        if (objective != this || objectiveState != ObjectiveState.Inactive)
            return;

        objectiveState = ObjectiveState.Started;

        if (onObjectiveStarted != null)
            onObjectiveStarted.Invoke(this);
    }

    void CompleteObjective(Objective objective)
    {
        if (objective != this || objectiveState != ObjectiveState.Started)
            return;

        objectiveState = ObjectiveState.Completed;

        if (onObjectiveCompleted != null)
            onObjectiveCompleted.Invoke(this);
    }

    void Start()
    {
        
    }
}
