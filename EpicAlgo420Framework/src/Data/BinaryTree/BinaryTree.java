package Data.BinaryTree;

import Interfaces.BinaryTree.IBinaryTree;

public class BinaryTree<T extends Comparable<T>> implements IBinaryTree<T>{

    public Node<T> root;


private static class Node<T extends Comparable<T>> {
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

public void traverseAndPrint() {
    print(root);
}

public void print(Node<T> node){
    if(node == null){
        return;
    }

    print(node.left);
    System.out.println(node);
    print(node.right);


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
