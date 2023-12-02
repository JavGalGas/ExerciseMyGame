using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM1
{
    class Runner
    {
        private string _name;
        private int _age;
        private double _position;
        private double _velocity;



        public Runner(string name, int age)
        {
            _name = name;
            _age = age;
            SetVelocity();
            _velocity=getVelocity();
            _position = 0;
        }
        public Runner() 
        {

        }

        public int getAge() { return _age; }
        public double getPosition() { return _position; }
        public double getVelocity() { return _velocity; }
        public void GetRefCount()
        {
            
        }
        public void SetVelocity()
        {
            _velocity = Utils.GetDoubleRandomBetween(1, 100-_age);
        }

        public Runner Clone()
        {
            Runner runner = new Runner();
            runner._name = _name;
            runner._age = _age;
            return runner;
        }
        public Runner Clone()
        { 
            return new Runner(_name, _age, _position, _velocity); 
        }
    }
}
