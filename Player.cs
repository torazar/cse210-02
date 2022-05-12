using System;

namespace Project_1 {
    public class Player {

        public int score = 300;

        public string Name { get; set; }

        
    
public void increasePoints(){
    score = score + 100;
   
    
}
public void decreasePoints(){
    score = score - 75;
    
    
}
public bool lose(){
    if(score <= 0){
        return false;
    }
}


    }

}