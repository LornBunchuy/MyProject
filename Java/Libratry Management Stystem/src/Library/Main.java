package Library;
import java.util.Scanner;
//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
   static Scanner s;
   static Database db;

    public static void main(String[] args) {
        db = new Database();
        System.out.println("Welcome to Library Management System!");
       int num ;
           System.out.println("0. Exit");
           System.out.println("1. Login");
           System.out.println("2. New User");
           s = new Scanner(System.in);
           num = s.nextInt();
           switch (num){
               case 1:
                   login();break;
               case 2:
                   newUser();break;
           }
    }
    private static void login(){
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
    private static void newUser(){
        System.out.println("Enter name: ");
        String name = s.next();
        if(db.getUserExit(name)){
            System.out.println("User exist!");
            newUser();
        }
        System.out.println("Enter phone number: ");
        String num = s.next();
        System.out.println("Enter email: ");
        String email = s.next();
        System.out.println("1. Admin: ");
        System.out.println("2. Normal user: ");
        int n2 = s.nextInt();
        User user;
        if (n2 == 1) {
            user = new Admin(name, email, num);

        }else{
           user = new NormalUser(name, email, num);

        }
        db.AddUser(user);
        user.menu(db, user);
    }

}