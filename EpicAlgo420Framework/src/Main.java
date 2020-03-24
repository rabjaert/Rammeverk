import java.util.ArrayList;
import java.util.Comparator;

import Data.BinaryTree.BinaryTree;
import Data.BinaryTree.BinaryTreeOld;
import Data.BinaryTree.TestGenericBinary;
import Data.Model.Actor;

public class Main {

    public static void main(String[] args) {

       BinaryTreeOld<Integer> etTre = new BinaryTreeOld<>();


        Integer [] data = {1,5,6,10,6,5,2};

        for(Integer i : data){
           etTre.insertWord(i);
        }

        etTre.inOrder(etTre.root);
       

        Actor person1 = new Actor("Roger", "Knutsen", 20);
        Actor person2 = new Actor("Robert", "Lundeby", 32);
        Actor person3 = new Actor("Robert", "Lundeby", 31);
        Actor person4 = new Actor("Snoop","Dog",40);
        Actor person5 = new Actor("Zelda", "Hambeg", 20);
        Actor person6 = new Actor("Niklas", "Berby", 31);
        Actor person7 = new Actor("Satan","Satansen", 69);
        Actor person8 = new Actor("Juda","Judasen",40);

        Comparator<Actor> actorNameComparator = new Comparator<Actor>() {
            @Override
            public int compare(Actor e1, Actor e2) {
                return e1.getFornavn().compareTo(e2.getFornavn());
            }
        };

        Comparator<Actor> compareFornavn = Comparator.comparing( Actor::getFornavn );
        Comparator<Actor> compareFornavnOgAlder = compareFornavn.thenComparingInt(Actor::getAlder);


        Comparator<Actor> byAge = (Actor o1, Actor o2) ->o1.getAlder() - o2.getAlder();

        TestGenericBinary<Actor> actorTre = new TestGenericBinary<>(compareFornavnOgAlder);

        Comparator<Actor> byFirstName = 
        (Actor o1, Actor o2)->o1.getFornavn().compareTo(o2.getFornavn());
        

        
        TestGenericBinary<Actor> ttt = new TestGenericBinary<>(byFirstName);

        //TestGenericBinary<Actor> acaaatorTre = new TestGenericBinary<>(byFirstName);

        ArrayList<Actor> ikkeAvføring = new ArrayList<Actor>();
        ikkeAvføring.add(person1);
        ikkeAvføring.add(person2);
        ikkeAvføring.add(person3);
        ikkeAvføring.add(person4);
        ikkeAvføring.add(person5);
        ikkeAvføring.add(person6);
        ikkeAvføring.add(person7);
        ikkeAvføring.add(person8);

       actorTre.insertItemList(ikkeAvføring);



       actorTre.deleteNode(actorTre.root, person2);
       System.out.println("\n");
       

       actorTre.inOrder(actorTre.root);
       
       
      
       
    

}
}