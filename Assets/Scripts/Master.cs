using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    [Tooltip("角色状态（0-正常，1-虚弱，2-防御，3-咏唱）")]
    [Range(0, 3)]
    public int State;

    [Header("基本属性")]
    [Tooltip("最大生命值")]
    public int maxHealth;
    [Tooltip("生命值")]
    public int Health;
    [Tooltip("最大法力值")]
    public int maxMana;
    [Tooltip("法力值")]
    public int Mana;
    [Tooltip("防御力")]
    public int Defense;
    [Tooltip("行动速度")]
    public float ActiveSpeed;

    [Header("元素属性")]
    public int Fire;//火
    public int Ice;//冰
    public int Nature;//自然
    public int Thunder;//雷    
    public int Light;//光
    public int Dark;//暗

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override string ToString()
    {
        return string.Format(
            "***角色属性*** Health:{0} | Mana:{1} | ActiveSpeed:{2} | ",
            Health, Mana, ActiveSpeed
            );
    }
}
