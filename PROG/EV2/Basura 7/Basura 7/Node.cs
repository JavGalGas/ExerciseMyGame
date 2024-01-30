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
        private List<Node<T>> _children;
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
            if(Parent != null)
            {
                _parent?.RemoveChild(this); /*(Remove debe ser private)*/

                _parent = null;
            }

        }

        public void SetParent(Node<T>? node) /*Podría ser bueno revisar si es null, para no confundirlo con un root*/
        {
            if (node == null)
                Unlink();
            else
                node.AddChild(this);
        }

        void AddChild(Node<T> node)
        {
            if (node == null)
                return;
            node.Unlink();
            node._parent=this;
            _children.Add(node);
        }

        private void RemoveChild(Node<T> child) 
        {
            int index = IndexOf(child);
            if (index != -1 && index < _children.Count)
                _children.RemoveAt(index);
            return;
        }

        private int IndexOf(Node<T> node)
        {
           for(int i = 0; i < _children.Count; i++)
           {
                if(node.Equals(_children[i]))
                    return i;
           }
           return -1;
        }
        
         public bool HasSibling()
        {
            return (_parent != null) ? _parent._children.Count > 0 :false;
            //if (_parent != null)
            //    return _parent._children?.Count > 0;
            //return false;


            //deberia intentarlo con Equals


        }

        public bool ContainsAncestor(Node<T> node)
        {
            if (node == null || _parent == null)
                return false;
            if(_parent == node)
                return true;
            return _parent.ContainsAncestor(node);
        }

        public bool ContainsDescendant(Node<T> node)
        {
            if(node == null)
                return false ;
            for(int i = 0; i < _children.Count; i++)
            {
                var child = _children[i];
                if(child.Equals(node))
                    return true;
                _children[i].ContainsDescendant(node);
            }
            return false;
        }
        //dado un nodo, invoca una función para él y todos sus descendientes
        delegate void VisitDelegate<t>(Node<T> node);

        void Visit(VisitDelegate<T> visitor)
        {
            if(visitor == null)
                return;
            visitor(this);
            for(int i = 0; i < _children.Count; i++)
            {
                _children[i].Visit(visitor);
            }
        }

        delegate /*void*/bool CheckDelegate<t>(Node<T> node);
        delegate /*void*/bool CheckDelegate2<t>(T element);

        Node<T> FindNode(CheckDelegate<T> checker)
        {
            if (checker == null)
                return new Node<T>();
            if (checker(this))
            {
                return this;
            }
            for (int i = 0; i < _children.Count; i++)
            {
                _children[i].FindNode(checker);
            }
            return new Node<T>();
        }

        Node<T> FindContent(CheckDelegate2<T> element)
        {
            if (element == null)
                return new Node<T>();
            if (element(this.Content))
            {
                return this;
            }
            for (int i = 0; i < _children.Count; i++)
            {
                _children[i].FindContent(element);
            }
            return new Node<T>();
        }
    }

}
