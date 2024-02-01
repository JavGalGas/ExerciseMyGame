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
        //WeakReference<Node<T>> _parent;
        //Se trabaja con una copia
#nullable disable
        private T Content  /*Item*/;
        private List<Node<T>> _children;
#nullable enable
        private Node<T>? _parent; /*(root tiene como _parent null)*/
        WeakReference<Node<T>?> _Parent = new WeakReference<Node<T>>(_parent);

        private Node<T>? Parent 
        {
            get { return _parent; }
            set { SetParent(this); }
        }/*Set(hacer función);*/
        
        private bool IsRoot => _parent == null;
        private bool IsLeaf => _children == null;
        private int ChildCount 
        { 
            get {   return (!IsLeaf) ? _children.Count : 0;} 
        }
        private int Level => GetLevel();
        private Node<T>? Root => GetRoot();


        public Node<T>? GetParent()
        {
            if (_parent == null)
                return null;

            Node<T>? result;
            _Parent.TryGetTarget(out result);
            return result;
        }

        public void SetParent2(WeakReference<Node<T>> parent)
        {
            if (parent == null)
                return;

            _Parent.SetTarget(parent);
            _Parent parent;
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

        public void AddChild(Node<T> node)
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

        private void Visit(VisitDelegate<T> visitor)
        {
            if(visitor == null)
                return;
            visitor(this);
            for(int i = 0; i < _children.Count; i++)
            {
                _children[i].Visit(visitor);
            }
        }

        delegate bool CheckDelegate<t>(Node<T> node);
        delegate bool CheckDelegate2<t>(T element);
        delegate bool CheckDelegate3<t>(List<Node<T>> node);

        Node<T> FindNode(CheckDelegate<T> checker)
        {
            if (checker == null)
#nullable disable
                return null;
#nullable enable
            if (checker(this))
                return this;
            for (int i = 0; i < _children.Count; i++)
            {
                var child = _children[i];
                var found = child.FindNode(checker);
                if(found != null)
                    return found;
            }
#nullable disable
            return null;
#nullable enable
        }

        private List<Node<T>> FindNode(CheckDelegate3<T> checker)//modificar
        {
            var result = new List<Node<T>>();
            //result.FindNode(checker, result)

            if (checker == null)
#nullable disable
                return null;
#nullable enable
            if (checker(this))
                result.Add(this);
            for (int i = 0; i < _children.Count; i++)
            {
                var child = _children[i];
                var found = child.FindNode(checker);
                if(found != null)
                    return found;
            }
            return result;
        }

        //private List<Node<T>> Filter(CheckDelegate3<T> checker)
        //{
        //
        //}

        //private void FindNode(CheckDelegate3<T> checker, List<Node<T>> list)
        //{

        //}

        Node<T> FindNode2(CheckDelegate2<T> element)
        {
            if (element == null)
#nullable disable
                return null;
#nullable enable
            if (element(this.Content))
                return this;
            for (int i = 0; i < _children.Count; i++)
            {
                var child = _children[i];
                var found = child.FindNode2(element);
                if(found != null)
                    return found;
            }
#nullable disable
            return null;
#nullable enable

        }
    }

}
