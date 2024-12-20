package Library;

import java.util.Scanner;

public class Exit implements IOOperation{
    Scanner s ;
    Database db;
    User user;
    @Override
    public void oper(Database db, User user) {
        this.db = db;
        this.user = user;
        System.out.println("Are you sure that you want to quit?\n"
                + "1. yes\n2. Main Menu");
        s = new Scanner(System.in);
        int i =s.nextInt();
        if(i==1){
            System.out.println("0. Exit");
            System.out.println("1. Login");
            System.out.println("2. New User");
            s = new Scanner(System.in);
            int num = s.nextInt();
            switch (num){
                case 1:
                    login();break;
                case 2:
                    newUser();break;
            }
        }else{
            user.menu(db, user);
        }
    }
    private  void login(){
        System.out.println("Enter phone number: ");
        String num = s.next();
        System.out.println("Enter email: ");
        String email = s.next();
        int n = db.login(num,email);
        if( n != -1){
            User user = db.getUser(n);
            user.menu(db, user);
        }else {
            System.out.println("User does't exist!");
        }
    }
    private void newUser(){
        System.out.println("Enter phone name: ");
        String name = s.next();
        System.out.println("Enter phone number: ");
        String num = s.next();
        System.out.println("Enter email: ");
        String email = s.next();
        System.out.println("1. Admin: ");
        System.out.println("2. Normanl user");
        int n = s.nextInt();
        User user;
        if (n == 2) {
            user = new Admin(name, email, num);

        }else{
            user = new NormalUser(name, email, num);

        }
        db.AddUser(user);
        user.menu(db, user);
    }

}
