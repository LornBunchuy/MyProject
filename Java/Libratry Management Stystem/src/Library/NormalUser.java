package Library;

import java.util.Scanner;

public class NormalUser extends User {
    public NormalUser(String name){
        super(name);
        this.operation  = new IOOperation[]{
            new ViewBooks(),
            new Search(),
            new PlaceOrder(),
            new BorrowBook(),
            new CalculateFine(),
            new ReturnBook(),
            new Exit()
        };
    }
    public NormalUser(String name, String email, String phonenumber){
        super(name, email, phonenumber);
        this.operation  = new IOOperation[]{
                new ViewBooks(),
                new Search(),
                new PlaceOrder(),
                new BorrowBook(),
                new CalculateFine(),
                new ReturnBook(),
                new Exit()
        };
    }
    @Override
    public void menu(Database db, User user){
        System.out.println("1. Views Books");
        System.out.println("2. Search");
        System.out.println("3. Place order");
        System.out.println("4. Borrow Books");
        System.out.println("5. Calculate fine");
        System.out.println("6. Return Book");
        System.out.println("7. Exit");

        Scanner s = new Scanner(System.in);
        int n = s.nextInt();
        this.operation[n-1].oper(db, user);
        s.close();
    }
    public String toString(){
        return name+ "<N/>"+ email +"<N/>"+ phoneNumber+"<N/>"+"Normal";
    }
}
