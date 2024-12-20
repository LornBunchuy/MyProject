package Library;

import java.util.Scanner;

public class Search implements IOOperation
{
    @Override
    public void oper(Database db, User user){
        System.out.println("\nEnter book name: ");
        Scanner s = new Scanner(System.in);
        String name = s.next();
        int i = db.getBook(name);
        if(i>-1){
            System.out.println( db.getBook(i).toString());
        }else{
            System.out.println("Book doesn't exist!");
        }
        user.menu(db,user);
    }
}
