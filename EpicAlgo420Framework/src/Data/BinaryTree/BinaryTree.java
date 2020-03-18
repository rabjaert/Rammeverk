package Data.BinaryTree;

import Interfaces.BinaryTree.IBinaryTree;

public class BinaryTree<E extends Comparable<E>> implements IBinaryTree<E>{

    private Node<E> root;

    

private static class Node<T extends Comparable<T>> {
    public T data;
    public Node<T> left, right;
    public int counter;

    public Node(T data, Node<T> left, Node<T> right) {
        this.data = data;
        this.left = left;
        this.right = right;
    }
    
}

public void insertNode(Node<T> node, T data) {

    if(node == null){
        node = new Node<T>(data,null,null);
    }

    else if(data.compareTo(node.data) == 0) {

        //node.increaseWordCounter();
    }

    else if(wordFunction.compareTo(node.word) < 0) {

        node.leftTreNode = insertNode(node.leftTreNode, wordFunction);
    }

    else {
        node.rightTreNode = insertNode(node.rightTreNode, wordFunction);

    }

    return node;
}



	@Override
	public void add(E element) {
		// TODO Auto-generated method stub
		
	}




	@Override
	public boolean contains(E element) {
		// TODO Auto-generated method stub
		return false;
	}




	@Override
	public void remove(E element) {
		// TODO Auto-generated method stub
		
	}

}