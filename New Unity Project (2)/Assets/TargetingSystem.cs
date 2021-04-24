using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingSystem : MonoBehaviour{


[SerializedField] private float range;
private Tower tower;

private void Awake(){
    tower = TryGetComponent<Tower>();
}


    // Update is called once per frame
    private void Update()
    {
       Collider2D[] colliderArray = Physics2D.OverlapCircleAll(transform.position,range);
       foreach (Collider2D collider2D in colliderArray){
           if (collider2D.TryGetComponent<Enemy>(out Enemy enemy)){
               tower.SetTarget(enemy);
           }
       }
        
    }
}
