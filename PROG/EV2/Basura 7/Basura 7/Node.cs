using Basura_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Basura_7
{
    public class Node<T>
    {
        private T Content  /*Item*/;
        private List<Node<T>>? _children;
        private Node<T>? _parent; /*(root tiene como _parent null)*/

        private Node<T>? Parent => _parent; /*Set(hacer función);*/
        private bool IsRoot => _parent == null;
        private bool IsLeaf => _children == null;
        private int ChildCount 
        { 
            get {   return (!IsLeaf) ? _children.Count : 0;} 
        }
        private int Level => GetLevel();
        private Node<T>? Root => GetRoot();

        public void Set(Node<T>? parent) /*Podría ser bueno revisar si es null, para no confundirlo con un root*/
        {
            _parent = parent;
        }

        public int GetLevel()
        {
            //return (_parent == null) ? 0 : _parent.GetLevel() + 1;

            //if (_parent == null)
            //    return 0;
            //return _parent.GetLevel() + 1;

            //(más eficiente con while)
            int level = 0;
            var p = Parent;
            while (p != null)
            {
                level++;
                p = p.Parent;
            }
            return level;
        }

        public Node<T>? GetRoot()
        {
            //return (_parent == null) ? this : _parent.GetRoot();


            //if (_parent == null)
            //    return this;

            //return _parent.GetRoot();

            var p = Parent;
            while (p != null)
            {
                p = p.Parent;
            }
            return p;

        }

        void Unlink()        /*(tambien se puede llamar Detach())*/
        {
            _parent?.Remove(this); /*(Remove debe ser private)*/
    
              _parent = null;
    
    
    
    
    
    
    
    
    
    
        }

        void AddChild(Node<T> child)
        {






        }

        private void Remove(Node<T> child) 
        { 
            
        }
    }
}
