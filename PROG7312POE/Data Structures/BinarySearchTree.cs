using System;
using System.Collections.Generic;

public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
{
    public class Node
    {
        public TKey Key;
        public TValue Value;
        public Node Left;
        public Node Right;

        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
            Left = null;
            Right = null;
        }
    }

    private Node root;
    public Node Root => root;

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//
    /// <summary>
    /// Inserts a new key-value pair into the binary search tree.
    /// </summary>
    public void Insert(TKey key, TValue value)
    {
        root = Insert(root, key, value);
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Helper method to insert a new key-value pair into the binary search tree.
    /// </summary>
    private Node Insert(Node node, TKey key, TValue value)
    {
        if (node == null)
        {
            return new Node(key, value);
        }

        int compare = key.CompareTo(node.Key);
        if (compare < 0)
        {
            node.Left = Insert(node.Left, key, value);
        }
        else if (compare > 0)
        {
            node.Right = Insert(node.Right, key, value);
        }
        else
        {
            node.Value = value;
        }

        return node;
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Tries to get the value associated with the specified key.
    /// </summary>
    public bool TryGetValue(TKey key, out TValue value)
    {
        Node node = root;
        while (node != null)
        {
            int compare = key.CompareTo(node.Key);
            if (compare < 0)
            {
                node = node.Left;
            }
            else if (compare > 0)
            {
                node = node.Right;
            }
            else
            {
                value = node.Value;
                return true;
            }
        }

        value = default(TValue);
        return false;
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Deletes the node with the specified key from the binary search tree.
    /// </summary>
    public bool Delete(TKey key)
    {
        bool deleted;
        root = Delete(root, key, out deleted);
        return deleted;
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Helper method to delete the node with the specified key from the binary search tree.
    /// </summary>
    private Node Delete(Node node, TKey key, out bool deleted)
    {
        if (node == null)
        {
            deleted = false;
            return null;
        }

        int compare = key.CompareTo(node.Key);
        if (compare < 0)
        {
            node.Left = Delete(node.Left, key, out deleted);
        }
        else if (compare > 0)
        {
            node.Right = Delete(node.Right, key, out deleted);
        }
        else
        {
            deleted = true;
            if (node.Left == null)
            {
                return node.Right;
            }
            else if (node.Right == null)
            {
                return node.Left;
            }
            else
            {
                Node minNode = GetMinNode(node.Right);
                node.Key = minNode.Key;
                node.Value = minNode.Value;
                node.Right = Delete(node.Right, minNode.Key, out _);
            }
        }

        return node;
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Gets the node with the minimum key in the binary search tree.
    /// </summary>
    private Node GetMinNode(Node node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node;
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Finds the minimum key in the binary search tree.
    /// </summary>
    public TKey FindMin()
    {
        if (root == null)
        {
            throw new InvalidOperationException("The tree is empty.");
        }

        return GetMinNode(root).Key;
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Finds the maximum key in the binary search tree.
    /// </summary>
    public TKey FindMax()
    {
        if (root == null)
        {
            throw new InvalidOperationException("The tree is empty.");
        }

        Node node = root;
        while (node.Right != null)
        {
            node = node.Right;
        }
        return node.Key;
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Performs an in-order traversal of the binary search tree.
    /// </summary>
    public void InOrderTraversal(Action<TKey, TValue> action)
    {
        InOrderTraversal(root, action);
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Helper method to perform an in-order traversal of the binary search tree.
    /// </summary>
    private void InOrderTraversal(Node node, Action<TKey, TValue> action)
    {
        if (node == null)
        {
            return;
        }

        InOrderTraversal(node.Left, action);
        action(node.Key, node.Value);
        InOrderTraversal(node.Right, action);
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Performs a pre-order traversal of the binary search tree.
    /// </summary>
    public void PreOrderTraversal(Action<TKey, TValue> action)
    {
        PreOrderTraversal(root, action);
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Helper method to perform a pre-order traversal of the binary search tree.
    /// </summary>
    private void PreOrderTraversal(Node node, Action<TKey, TValue> action)
    {
        if (node == null)
        {
            return;
        }

        action(node.Key, node.Value);
        PreOrderTraversal(node.Left, action);
        PreOrderTraversal(node.Right, action);
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Performs a post-order traversal of the binary search tree.
    /// </summary>
    public void PostOrderTraversal(Action<TKey, TValue> action)
    {
        PostOrderTraversal(root, action);
    }

    //<----------------------------------------------------------------------------------------------------------------------------------------------->//

    /// <summary>
    /// Helper method to perform a post-order traversal of the binary search tree.
    /// </summary>
    private void PostOrderTraversal(Node node, Action<TKey, TValue> action)
    {
        if (node == null)
        {
            return;
        }

        PostOrderTraversal(node.Left, action);
        PostOrderTraversal(node.Right, action);
        action(node.Key, node.Value);
    }
}
//------------------------------------------------------------------END OF FILE----------------------------------------------------------------------------------------->//
