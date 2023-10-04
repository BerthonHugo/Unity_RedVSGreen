using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArmyElement : MonoBehaviour, IArmyElement
{
	public ArmyManager ArmyManager { get; set; }
	[SerializeField] Health m_Health;
    [SerializeField] public int m_tag = 0;
    [SerializeField] public int m_ArmyGroup = 0;
    public float Health { get => m_Health.Value; }
}
