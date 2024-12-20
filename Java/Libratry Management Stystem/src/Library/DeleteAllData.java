package Library;

import java.util.Scanner;

public class DeleteAllData implements IOOperation {
    @Override
    public void oper(Database db, User user){
        System.out.println("Are you sure that you want to delete all data?\n"
        + "1. Continue\n2. Main Menu");
        Scanner s =  new Scanner(System.in);
        int i =s.nextInt();
        if(i==1){
            db.deleteAllData();
        }else{
            user.menu(db, user);
        }
    }
}
