using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogStats : MonoBehaviour
{
    public class Stats
    {
        private float health; //Can change this to int or decimal
        private float strength;
        private float moveSpeed;
        private float attackSpeed;
        private float range;
        private int items;
        private int money;
        private string dog;
        private int dogsKilled;
        private bool isStoryMode;
        private int floors;

        /// <summary>
        /// Default Constructor. Copy and paste changes to do different classes
        /// </summary>
        public Stats()
        {
            health = 0;
            strength = 5;
            moveSpeed = 10f;
            attackSpeed = 10f;
            range = 0;
            items = 0;
            dog = "";
            money = 0;
            dogsKilled = 0;
            floors = 0;
        }

        /// <summary>
        /// Property for dog's Health stat.
        /// </summary>
        /// 

        public void DoggoChosen()
        {
            //if (chosen == some dog){}
            health = 100;
            strength = 3;
            moveSpeed = 10f;
            attackSpeed = 10f;
            range = 0;
            items = 0;

        }
        public float _Health
        {
            get { return health; }
            set { health = value; }
        }

        /// <summary>
        /// Property for dog's Strength stat
        /// </summary>
        public float _Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        /// <summary>
        /// Property for dog's movespeed stat.
        /// </summary>
        public float _MoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }
        /// <summary>
        /// Property for dog's attackspeed stat.
        /// </summary>
        public float _AttackSpeed
        {
            get { return attackSpeed; }
            set { attackSpeed = value; }
        }

        /// <summary>
        /// Property for dog's Range stat.
        /// </summary>
        public float _Range
        {
            get { return range; }
            set { range = value; }
        }

        /// <summary>
        /// Property for dog's inventory space.
        /// </summary>
        public int _Items
        {
            get { return items; }
            set { items = value; }
        }

        /// <summary>
        /// Property for the name of the dog.
        /// </summary>
        public string _Dog
        {
            get { return dog; }
            set { dog = value; }
        }

        /// <summary>
        /// Property for amount of Dogecoin.
        /// </summary>
        public int _DogeCoin
        {
            get { return money; }
            set { money = value; }
        }
        /// <summary>
        /// Property for the number of friendly dogs killed.
        /// </summary>
        public int _DoggosKilled
        {
            get { return dogsKilled; }
            set { dogsKilled = value; }
        }

        /// <summary>
        /// Property for current game mode.
        /// </summary>
        public bool _IsStoryMode
        {
            get { return isStoryMode; }
            set { isStoryMode = value; }
        }

        public int IncreaseCoinCount()
        {
            _DogeCoin++;
            return _DogeCoin;
        }

        /// <summary>
        /// Property for amount of Dogecoin.
        /// </summary>
        public int _Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        public int NextFloor()
        {
            _Floors++;
            return _Floors;
        }

        //pour michelle desu
        //public int IncreasedDoggosKilled()
        //{

        //}
    }
}


        
