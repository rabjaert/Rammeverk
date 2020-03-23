package Data.BinaryTree;

import Interfaces.BinaryTree.IBinaryTree;

public class BinaryTreeOld<T extends Comparable<T>> implements IBinaryTree<T>{

    public Node<T> root;

    public BinaryTreeOld() {
        this.root = null;

    }


public static class Node<T extends Comparable<T>> {
    public T data;
    public Node<T> left, right;
    //public int counter;

    public Node(T data) {
        this.data = data; 
        this.left = null;
        this.right = null;
    }
} 
public void inOrder(Node<T> root) {
    if (root != null) {
        inOrder(root.left);
        System.out.print(root.data.toString() +" \n");
        inOrder(root.right);
    }
}

public void preOrder(Node<T> root) {
    if (root != null) {
        System.out.print(root.data.toString() +" \n");
        preOrder(root.left);
        preOrder(root.right);
    }
}

public void postOrder(Node<T> root) {
    if (root != null) {
        postOrder(root.left);
        postOrder(root.right);
        System.out.print(root.data.toString() +" \n");
    }
}

public Node<T> insertNode(Node<T> node, T data) {

    if(node == null){
        node = new Node<T>(data);
    }

    else if(data.compareTo(node.data) < 0) {

        node.left = insertNode(node.left, data);
    }

    else {
        node.right = insertNode(node.right, data);

    }

    return node;
}


public void insertWord(T word){
    root = insertNode(root, word);
}

    @Override
    public void add(T element) {
        // TODO Auto-generated method stub

    }

    @Override
    public boolean contains(T element) {
        // TODO Auto-generated method stub
        return false;
    }

    @Override
    public void remove(T element) {
        // TODO Auto-generated method stub

    }


    @Override
    public String toString() {
        return "TreeNode{" + root +
                "data=" + root.data +
                '}';
    }



}
