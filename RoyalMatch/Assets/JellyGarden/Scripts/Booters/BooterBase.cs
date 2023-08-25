using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooterBase : MonoBehaviour
{
    public BootersType bootersType;
    public virtual bool UseBooter(Square square)
    {
        return false; 
    }
}
