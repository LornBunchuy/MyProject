import java.util.Scanner;
public class GusTheNumberGame {
    private Scanner scanner;
    public static void main(String[] args){
        GusTheNumberGame gusTheNumberGame = new GusTheNumberGame();
        gusTheNumberGame.run();
    }
    public GusTheNumberGame(){
        scanner = new Scanner(System.in);
    }
    private void run(){
        int the_num = (int) (Math.random() * 100);
        while(true){
            System.out.println("so you wanna quite: ");
            String ans = scanner.nextLine();

            if(ans.equals("yes")){
                break;
            }
            System.out.println("gusts the number!: ");
            int Gussed_num  = scanner.nextInt();
            scanner.nextLine();
            if(Gussed_num == the_num){
                System.out.println("you win!");
                break;

            }if(Gussed_num < the_num){
                System.out.println("the number is larger ! ");
            }
            else if(Gussed_num > the_num){
                System.out.println("nope, the number is less ! ");
            }
        }
    }
}
