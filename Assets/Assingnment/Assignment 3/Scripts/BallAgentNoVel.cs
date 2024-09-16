using System;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class BallAgentNoVel : Agent
{
    private Rigidbody _rb;
    [SerializeField] private float acceleration = 10f;
    [SerializeField] private Transform target;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.localPosition.y < -0.5f)
        {
            SetReward(-1f);
            EndEpisode();
        }
    }

    public override void OnEpisodeBegin()
    { 
        if (transform.localPosition.y < -0.5f)
        {
            _rb.angularVelocity = Vector3.zero;
            _rb.velocity = Vector3.zero;
            transform.localPosition = new Vector3( 0, 0f, 0);
        }

        target.localPosition = new Vector3(Random.Range(-4, 4),
            0f,
            Random.Range(-4, 4));
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(target.localPosition);
        sensor.AddObservation(transform.localPosition);
        // sensor.AddObservation(_rb.velocity.x);
        // sensor.AddObservation(_rb.velocity.z);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        Vector3 forceDirection = Vector3.zero;
        forceDirection.x = actions.ContinuousActions[0];
        forceDirection.z = actions.ContinuousActions[1];
        _rb.AddForce(forceDirection.normalized * acceleration, ForceMode.Acceleration);
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag($"Finish")) return;
        SetReward(+1f);
        EndEpisode();
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var continuousActionOut = actionsOut.ContinuousActions;
        continuousActionOut[0] = Input.GetAxis("Horizontal");
        continuousActionOut[1] = Input.GetAxis("Vertical");
    }
}
