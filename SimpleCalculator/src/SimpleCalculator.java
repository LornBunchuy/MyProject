import java.util.*;
public class SimpleCalculator {
    public  static void main(String[] args){
        System.out.println(" SIMPLE CALULATOR ");
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a: ");
        int a = sc.nextInt();
        System.out.println("Enter b");
        int b =  sc.nextInt();
        System.out.println("select the  option below" + "to perform Particular Operation");
        System.out.println(" 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division \n 5.Remainder");
        int option = sc.nextInt();
        switch (option){
            case 1:
                System.out.println("a + b = " + (a+b));
                break;
            case 2:
                System.out.println("a - b = " + (a-b));
                break;
            case 3:
                System.out.println("a * b = " + (a*b));
                break;
            case 4:
                System.out.println("a / b = " + (a/b));
                break;
            case 5:
                System.out.println("a % b = " + (a%b));
                break;
            default:
                System.out.println("Enter valid Option : ");

        }
    }
}
