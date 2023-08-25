using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterNavmeshAgent : ICharacterAgent
{
    public CharacterNavmeshAgent(NavMeshAgent agent)
    {
        _navMeshAgent = agent;
    }

    private NavMeshAgent _navMeshAgent;

    public float Speed
    {
        get { return _navMeshAgent.speed; }
        set { _navMeshAgent.speed = value; }
    }

    public float StoppingDistance
    {
        get { return _navMeshAgent.stoppingDistance; }
        set { _navMeshAgent.stoppingDistance = value; }
    }

    public Vector3 Destination { get; set; }
    public float RemainingDistance => _navMeshAgent.remainingDistance;
    public Vector3 Velocity => _navMeshAgent.velocity;
    public float Height => _navMeshAgent.height;

    public bool IsEnabled()
    {
        return _navMeshAgent.enabled;
    }

    public bool IsValid()
    {
        return _navMeshAgent.isOnNavMesh;
    }

    public bool IsMoving()
    {
        return _navMeshAgent.velocity.magnitude > 0;
    }

    public bool IsStopped()
    {
        return _navMeshAgent.isStopped;
    }

    public bool IsCalculating()
    {
        return _navMeshAgent.pathPending;
    }

    public bool ShouldStartMoving()
    {
        return !IsMoving() && !IsStopped() && IsValid();
    }

    public bool HasFullPath()
    {
        return _navMeshAgent.hasPath;
    }

    public bool HasPartialPath()
    {
        return _navMeshAgent.pathStatus == NavMeshPathStatus.PathPartial;
    }

    public bool ShouldCheckTimeOffset()
    {
        return Time.frameCount % 10 == 0; // Check every 10 frames
    }

    public float GetPathLength(Vector3 target)
    {
        NavMeshPath path = new NavMeshPath();
        if (_navMeshAgent.CalculatePath(target, path))
        {
            float pathLength = 0f;
            for (int i = 1; i < path.corners.Length; i++)
            {
                pathLength += Vector3.Distance(path.corners[i - 1], path.corners[i]);
            }

            return pathLength;
        }

        return Mathf.Infinity;
    }

    public void Enable()
    {
        _navMeshAgent.enabled = true;
    }

    public void Disable()
    {
        _navMeshAgent.enabled = false;
    }

    public void ResetState()
    {
        _navMeshAgent.ResetPath();
    }

    public void Stop()
    {
        _navMeshAgent.isStopped = true;
    }

    public void Move()
    {
        _navMeshAgent.isStopped = false;
    }

    //set vị trí đột biến kiểu telee 
    public void Warp(Vector3 position)
    {
        _navMeshAgent.Warp(position);
    }

    public AgentType GetAgentType()
    {
        return AgentType.NavmeshAgent;
    }

    public void SetPosition(Vector3 position)
    {
        Destination = position;
        _navMeshAgent.SetDestination(position);
    }

    public void Update()
    {
        // No need to explicitly call Update() for NavMeshAgent in this implementation
    }
}