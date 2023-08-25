using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;
using UnityEngine.AI;

//MỘT NHÂN VẬT CÓ THỂ CÓ NHIỀU PHƯƠNG THỨC DI CHUYỂN::
//ĐƯỢC TỪ LOẠI NHÂN ẬT NÀO TRUYỀN VÀO ICHARACTERAGENT
public class CharacterAgentController : MonoBehaviour
{
    [SerializeField] private Character character;
    [SerializeField] private NavMeshAgent navMeshAgent;

    private List<ICharacterAgent> _agents;
    private ICharacterAgent _activeAgent;

    public float Speed
    {
        get { return _activeAgent.Speed; }
        set { _activeAgent.Speed = value; }
    }

    public float StoppingDistance
    {
        get { return _activeAgent.StoppingDistance; }
        set { _activeAgent.StoppingDistance = value; }
    }

    public Vector3 Destination
    {
        get { return _activeAgent.Destination; }
        set { _activeAgent.Destination = value; }
    }

    public float RemainingDistance => _activeAgent.RemainingDistance;

    public Vector3 Velocity => _activeAgent.Velocity;

    //public float Height => 0f;

    public void Init()
    {
        _agents = new List<ICharacterAgent>()
        {
            new CharacterNavmeshAgent(navMeshAgent)
        };
        SetAgent(_agents[0]);
    }

    //truyene agent vafo 
    public void SetAgent(AgentType agentType)
    {
        var agent = _agents.Find(agent => agent.GetAgentType() == AgentType.NavmeshAgent);
        if (agent != null)
        {
            SetAgent(agent);
        }
    }

    public void SetAgent(ICharacterAgent newAgent)
    {
        ReleaseActiveAgent();
        _activeAgent = newAgent;
        _activeAgent.Enable();
    }

    public bool IsInitialized()
    {
        return _activeAgent != null;
    }

    public bool IsEnabled()
    {
        return _activeAgent.IsEnabled();
    }

    public void Enable()
    {
        _activeAgent.Enable();
    }

    public void Disable()
    {
        _activeAgent.Disable();
    }

    public bool IsValid()
    {
        return _activeAgent.IsValid();
    }

    public bool IsMoving()
    {
        return _activeAgent.IsMoving();
    }

    public bool IsStopped()
    {
        return _activeAgent.IsStopped();
    }

    public bool IsCalculating()
    {
        return _activeAgent.IsCalculating();
    }

    public bool HasFullPath()
    {
        return _activeAgent.HasFullPath();
    }

    public bool HasPartialPath()
    {
        return _activeAgent.HasPartialPath();
    }

    public float GetPathLength(Vector3 target)
    {
        return _activeAgent.GetPathLength(target);
    }

    public void ResetState()
    {
        _activeAgent.ResetState();
    }

    public void Stop()
    {
        _activeAgent.Stop();
    }

    public void Move()
    {
        _activeAgent.Move();
    }

    [Button]
    public void SetPosition(Vector3 position)
    {
        _activeAgent.SetPosition(position);
    }

    public void Update()
    {
        _activeAgent.Update();
    }

    public AgentType GetAgentType()
    {
        return _activeAgent.GetAgentType();
    }

    public void Warp(Vector3 position)
    {
        _activeAgent.Warp(position);
    }

    public bool ShouldStartMoving()
    {
        return _activeAgent.ShouldStartMoving();
    }

    public bool ShouldCheckTimeOffset()
    {
        return _activeAgent.ShouldCheckTimeOffset();
    }


    private void ReleaseActiveAgent()
    {
        if (_activeAgent != null)
        {
            _activeAgent.Disable();
            _activeAgent = null;
        }
    }

    private void AssignActiveAgent(ICharacterAgent agent)
    {
        _activeAgent = agent;
        _activeAgent.Enable();
    }
}