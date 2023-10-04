using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using static UnityEngine.GraphicsBuffer;
using System.ComponentModel;
using System.Linq;

[TaskCategory("MyTasks")]
[TaskDescription("Select non targeted enemy turret")]

public class SelectEnemyTurretRed : Action
{
	IArmyElement m_ArmyElement;
	public SharedTransform target;
	public SharedFloat minRadius;
	public SharedFloat maxRadius;

	private int count = 0;	

    Turret turret;
    public override void OnAwake()
	{
		m_ArmyElement =(IArmyElement) GetComponent(typeof(IArmyElement));
		turret = GetComponent<Turret>();
	}

	public override TaskStatus OnUpdate()
	{
		if (target == null) return TaskStatus.Failure;
		if (m_ArmyElement.ArmyManager == null) return TaskStatus.Running; // la référence à l'armée n'a pas encore été injectée

		//target.Value = m_ArmyElement.ArmyManager.GetRandomEnemyOfTypeByDistance<Turret>(transform.position,minRadius.Value,maxRadius.Value)?.transform;
		if (count < 3)
		{
            target.Value = m_ArmyElement.ArmyManager.GetEnemyOfTypeByTag<Turret>()?.transform;
			count++;
        }
		else
		{
            target.Value = m_ArmyElement.ArmyManager.GetNextEnemyOfTypeByTag<Turret>()?.transform;
			count = 0;
        }
        


		if (target.Value != null) return TaskStatus.Success;
		else
		{
            target.Value = m_ArmyElement.ArmyManager.GetRandomEnemyOfTypeByDistanceSorted<Drone>(transform.position)?.transform;
            if (target.Value != null) return TaskStatus.Success;
            else return TaskStatus.Failure;
		}
	}
}