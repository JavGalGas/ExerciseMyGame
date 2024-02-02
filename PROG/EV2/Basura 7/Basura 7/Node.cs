using System.Xml.Linq;

namespace Basura_7
{
    public class Node<T>//implementar WeakReference en parent
    {
        //WeakReference<Node<T>> _parent;
        //Se trabaja con una copia
#nullable disable
        private T Content  /*Item*/;
        private List<Node<T>> _children;
#nullable enable
        //private Node<T>? _parent; /*(root tiene como _parent null)*/
        WeakReference<Node<T>?> _parent;
#nullable disable
        public Node(T content)
#nullable enable
        {
            Content = content;
        }

        public Node(T content, Node<T>? node)
        {
            Content=content;
            SetParent(node);
        }

        public Node(Node<T>? node, List<Node<T>> children)
        {
            SetParent(node);
            //for(int i = 0; i < children.Count; i++)
            //{
            //    Node<T> node = children[i];
            //    AddChild(node);
            //}

            foreach (var child in children)
                AddChild(child);

        }

        private Node<T>? Parent
        {
            get => GetParent();
            set => SetParent(this);
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
            _parent.TryGetTarget(out result);
            return result;
        }

        public void SetParent(Node<T>? node)
        {
            if (node == null || node == this || node == GetParent())
                return;
            if (node.ContainsDescendant(this) || ContainsAncestor(node))
                return;
            else
            {
                Unlink();
                //node.AddChild(this);
                var parent = new WeakReference<Node<T>?>(node);
                _parent = parent;
            }
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

        public void Unlink()        /*(tambien se puede llamar Detach())*/
        {
            if (Parent != null)
            {
                //var parent = GetParent();
                //parent?.RemoveChild(this); /*(Remove debe ser private)*/
                Parent.RemoveChild(this);
#nullable disable
                _parent = null;
#nullable enable
            }

        }

        //public void SetParent(Node<T>? node) /*Podría ser bueno revisar si es null, para no confundirlo con un root*/
        //{
        //    if (node == null || node == this || ContainsDescendant(node) || ContainsAncestor(this))
        //        Unlink();
        //    else
        //        node.AddChild(this);
        //}

        public void AddChild(Node<T> node)
        {
            if (node == null|| node == this || node.ContainsDescendant(this) || ContainsAncestor(node))
                return;
            node.Unlink();
            node.SetParent(this);
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
                if(node== _children[i]  /*node.Equals(_children[i])*/)
                    return i;
           }
           return -1;
        }
        
        private Node<T>? GetChildAt(int index)
        {
            return (index <= 0 || index >= _children.Count) ? null : _children[index];
        }

        public bool HasSibling()
        {
#nullable disable
            return (GetParent() != null) ? Parent._children.Count > 1 : false;
#nullable enable
            //if (_parent != null)
            //    return _parent._children?.Count > 0;
            //return false;
        }


        public bool ContainsAncestor(Node<T> node)
        {
            var parent = GetParent();
            if (node == null || parent == null)
                return false;
            if(parent == node)
                return true;
            return parent.ContainsAncestor(node);
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

        public delegate bool CheckDelegate<t>(Node<T> node);
        public delegate bool CheckDelegate2<t>(T element);
        //public delegate bool CheckDelegate3<t>(List<Node<T>> node);

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

        private List<Node<T>> FindListNode(CheckDelegate<T> checker)//modificar
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
                var found = child.FindListNode(checker);
                if(found != null)
                    return found;
            }
            return result;
        }

        private List<Node<T>> Filter(CheckDelegate<T> checker) //hacer Filter (copia pega List FindNode y modificar)
        {
            var result = new List<Node<T>>();

            if (checker == null)
#nullable disable
                return null;
#nullable enable
            if (checker(this))
                result.Add(this);
            for (int i = 0; i < _children.Count; i++)
            {
                var child = _children[i];
                var found = child.FindListNode(checker);
                if (found != null)
                    return found;
            }
            return result;

        }

        private void FindNodeInternal(CheckDelegate<T> checker, List<Node<T>> list)
        {
            for(int i= 0; i < _children.Count;i++)
            {
                var foundNode = _children[i].FindNodeInternal(checker, list);
            }
        }

        Node<T> FindNode2(CheckDelegate2<T> element)
        {
            if (element == null)
#nullable disable
                return null;
#nullable enable
            if (element(Content))
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
        

        public override string ToString()
        {
            string result = "";
            T content = Content;
            result = $"El contenido del nodo es: {content}";
            return result;
        }
    }

}
