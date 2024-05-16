using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IACharacterVehiculoLand : IACharacterVehiculo
{
    protected Vector3 normales = Vector3.zero;
    protected float speedRotation = 0;

    public float RangeWander;
    Vector3 positionWander;
    float FrameRate = 0;
    float Rate = 4;

    public override void LoadComponent()
    {
        base.LoadComponent();
    }
    public virtual void LookEnemy()
    {
        if (visionSensor.EnemyView == null) return;
        Vector3 dir = (visionSensor.EnemyView.transform.position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(dir);
        rot.x = 0;
        rot.z = 0;
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * 50);
    }
    public virtual void LookPosition(Vector3 position)
    {

        Vector3 dir = (position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(dir);
        rot.x = 0;
        rot.z = 0;
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * speedRotation);
    }

    public virtual void MoveToPosition(Vector3 pos)
    {
        agent.SetDestination(pos);
    }
    public virtual void MoveToEnemy()
    {
        if (visionSensor.EnemyView == null) return;
        MoveToPosition(visionSensor.EnemyView.transform.position);
    }
    public virtual void MoveToAllied()
    {
        //if (AIEye.ViewAllie == null) return;
        //MoveToPosition(AIEye.ViewAllie.transform.position);
    }
    public virtual void MoveToEvadEnemy()
    {
        if (visionSensor.EnemyView == null) return;
        Vector3 dir = (transform.position - visionSensor.EnemyView.transform.position).normalized;
        Vector3 newPosition = transform.position + dir * 5f;
        MoveToPosition(newPosition);
        LookPosition(newPosition);
    }
    public Vector3 ColliderWall()
    {

        normales = Vector3.zero;
        Ray[] arrayRay = new Ray[3];
        arrayRay[0] = new Ray(health.AimOffset.position, health.AimOffset.right);
        arrayRay[1] = new Ray(health.AimOffset.position, -health.AimOffset.forward);
        arrayRay[2] = new Ray(health.AimOffset.position, -health.AimOffset.right);
        for (int i = 0; i < 2; i++)
        {
            RaycastHit hit;
            if (Physics.Raycast(arrayRay[i], out hit, 3, visionSensor.MainVision.Occlusionlayers))
            {
                normales += hit.normal;
            }
        }
        return normales;
    }
    public virtual void MoveToStrategy()
    {

        if (visionSensor.EnemyView == null) return;
        Vector3 dir = Vector3.zero;
        normales = ColliderWall();
        if (normales != Vector3.zero)
            dir = normales;
        else
        {
            dir = (transform.position - visionSensor.EnemyView.transform.position).normalized;
        }
        Vector3 newPosition = transform.position + dir * 2;
        MoveToPosition(newPosition);


    }
    Vector3 RandoWander(Vector3 position, float range)
    {
        Vector3 randP = Random.insideUnitSphere * range;
        randP.y = transform.position.y;
        return position + randP;
    }
    public virtual void MoveToWander()
    {
        if (visionSensor.EnemyView != null) return;

        float distance = (transform.position - positionWander).magnitude;

        if (distance < 2)
        {
            positionWander = RandoWander(transform.position, RangeWander);
        }

        if (FrameRate > Rate)
        {
            FrameRate = 0;
            positionWander = RandoWander(transform.position, RangeWander);
        }
        FrameRate += Time.deltaTime;


        MoveToPosition(positionWander);
    }
    public void DrawGizmos()
    {
        if (health != null)
        {
            Ray[] arrayRay = new Ray[3];
            arrayRay[0] = new Ray(health.AimOffset.position, health.AimOffset.right);
            arrayRay[1] = new Ray(health.AimOffset.position, -health.AimOffset.forward);
            arrayRay[2] = new Ray(health.AimOffset.position, -health.AimOffset.right);
            for (int i = 0; i < arrayRay.Length; i++)
            {
                RaycastHit hit;
                if (Physics.Raycast(arrayRay[i], out hit, 3, visionSensor.MainVision.Occlusionlayers))
                {
                    Gizmos.color = Color.red;

                }
                else
                {
                    Gizmos.color = Color.blue;
                }

                Gizmos.DrawLine(arrayRay[i].origin, arrayRay[i].origin + arrayRay[i].direction * 3f);
                Gizmos.DrawSphere(arrayRay[i].origin + arrayRay[i].direction * 3f, 0.7f);
            }


            Gizmos.color = Color.yellow;
            if (normales != Vector3.zero)
            {
                Gizmos.DrawLine(health.AimOffset.position, health.AimOffset.position + normales * 2f);
                Gizmos.DrawSphere(health.AimOffset.position + normales * 2f, 0.5f);
            }
        }
    }
}
