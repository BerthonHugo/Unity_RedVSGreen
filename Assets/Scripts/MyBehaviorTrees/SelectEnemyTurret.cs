using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using static UnityEngine.GraphicsBuffer;
using System.ComponentModel;

[TaskCategory("MyTasks")]
[TaskDescription("Select non targeted enemy turret")]

public class SelectEnemyTurret : Action
{
	IArmyElement m_ArmyElement;
	public SharedTransform target;
	public SharedFloat minRadius;
	public SharedFloat maxRadius;

    Turret turret;
    public override void OnAwake()
	{
		m_ArmyElement =(IArmyElement) GetComponent(typeof(IArmyElement));
		turret = GetComponent<Turret>();
	}

	public override TaskStatus OnUpdate()
	{
		if (m_ArmyElement.ArmyManager == null) return TaskStatus.Running; // la r�f�rence � l'arm�e n'a pas encore �t� inject�e

        //target.Value = m_ArmyElement.ArmyManager.GetRandomEnemyOfTypeByDistance<Turret>(transform.position,minRadius.Value,maxRadius.Value)?.transform;


        target.Value = m_ArmyElement.ArmyManager.GetRandomEnemyOfTypeByDistance<Turret>(transform.position, minRadius.Value, maxRadius.Value)?.transform;

        if (target.Value != null) return TaskStatus.Success;
		else return TaskStatus.Failure;

	}
}