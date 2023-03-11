using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChimmyBear
{
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("目標物件")]
        private Transform target;

        private void Update()
        {
            LookTarget();
        }
        /// <summary>
        /// 面向目標
        /// </summary>
        private void LookTarget()
        {
            //變形元件.面向(目標物件)
            transform.LookAt(target);
            //x與z歸零
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        }
    }
    

}

