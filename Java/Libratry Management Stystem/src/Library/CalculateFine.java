package Library;

import org.w3c.dom.ls.LSOutput;

import java.util.Scanner;

public class CalculateFine implements IOOperation {
    @Override
    public void oper(Database db, User user) {
        Scanner s = new Scanner(System.in);
        System.out.println("Enter book name: ");
        String bookname= s.next();
        boolean done = true;
      for(Borrowing b: db.getBrws()){
          if(b.getBook().getName().matches(bookname) && b.getUser().getName().matches(user.getName())){
              if(b.getDaysleft() > 0){
                  System.out.println("You are late!" + "You have to pay " + Math.abs(b.getDaysleft()* 50)+ "as fine\n");
              }else{
                  System.out.println("You don't have to pay fine\n");
              }
              done = false;
              break;
          }
      }
      if(done){
          System.out.println("You didn't borrow to this book!\n");
        }
      user.menu(db, user);
    }
}
