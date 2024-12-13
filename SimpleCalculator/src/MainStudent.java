//import java.util.Scanner;
//
//public class MainStudent {
//    public static void main(String[] args){
//        StudentManagementSystem sms = new StudentManagementSystem();
//        Scanner scanner = new Scanner(System.in);
//        int choice;
//        do{
//            System.out.println("\nStudent Management System");
//            System.out.println("1. Add student");
//            System.out.println("2. Display all Student");
//            System.out.println("3. Search Student by ID");
//            System.out.println("4. Delete Student");
//            System.out.println("5. Exit\n");
//            System.out.println("Enter your choice: ");
//            choice =  scanner.nextInt();
//            scanner.nextLine();
//
//            switch (choice){
//                case 1:
//                    System.out.println("Enter Student name: ");
//                    String name = scanner.nextLine();
//                    System.out.println("Enter Student ID: ");
//                    String id = scanner.nextLine();
//                    System.out.println("Enter Student Grade: ");
//                    double grade = scanner.nextDouble();
//                    sms.addStudent(name, id, grade);
//                    break;
//                case 2:
//                    sms.displayStudent();
//                    break;
//                case 3:
//                    System.out.println("Enter Student ID to search: ");
//                    String searchId = scanner.nextLine();
//                    sms.searchStudent(searchId);
//                    break;
//                case 4:
//                    System.out.println("Enter Student ID to delete: ");
//                    String deleteId = scanner.nextLine();
//                    sms.deleteStudent(deleteId);
//                    break;
//                case 5:
//                    System.out.println("System Exit!");
//                    break;
//                default:
//                    System.out.println("Invalid choice! Please try again.");
//            }
//        }while(choice !=5);
//        scanner.close();
//    }
//}









import java.util.Scanner;
public class MainStudent{
    public static void main(String[] args){
        StudentManagementSystem sms = new StudentManagementSystem();
        Scanner scanner = new Scanner(System.in);
        int choice ;
        do{
            System.out.println("\nSTUDENT MANAGEMENT SYSTEM\n");
            System.out.println("1. Add Student");
            System.out.println("2. Search Student");
            System.out.println("3. Display Student");
            System.out.println("4. Delete Student");
            System.out.println("5. Exit");
            System.out.println("Enter your choice: ");
            choice = scanner.nextInt();
            scanner.nextLine();
            switch (choice){
                case 1:
                    System.out.println("Enter name: ");
                    String name = scanner.nextLine();
                    System.out.println("Enter ID: ");
                    String id = scanner.nextLine();
                    System.out.println("Enter Grade: ");
                    double grade = scanner.nextDouble();
                    sms.addStudent(name, id, grade);
                    break;
                case 2:
                    System.out.println("Enter Student ID: ");
                    String searchId = scanner.nextLine();
                    sms.searchStudent(searchId);
                    break;
                case 3:
                    sms.displayStudent();
                    break;
                case 4:
                    System.out.println("Enter Student ID: ");
                    String deleteId = scanner.nextLine();
                    sms.deleteStudent(deleteId);
                    break;
                default:
                    System.out.println("Invalid choice! please try again!");
                    break;
            }
        }while(choice !=5);
        scanner.close();
    }
}