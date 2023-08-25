using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//dành cho bay và cho đi bộ tùy trường hợp phét hay gì:::
public interface ICharacterAgent
{
    float Speed { get; set; }

    float StoppingDistance { get; set; }

    Vector3 Destination { get; set; }

    float RemainingDistance { get; }

    Vector3 Velocity { get; }

    float Height { get; }

    bool IsEnabled();

    bool IsValid();

    bool IsMoving();

    bool IsStopped();

    bool IsCalculating();

    bool ShouldStartMoving();

    bool HasFullPath();

    bool HasPartialPath();

    bool ShouldCheckTimeOffset();

    float GetPathLength(Vector3 target);

    void Enable();

    void Disable();

    void ResetState();

    void Stop();

    void Move();

    void SetPosition(Vector3 position);

    void Update();

    void Warp(Vector3 position);

    AgentType GetAgentType();
}
