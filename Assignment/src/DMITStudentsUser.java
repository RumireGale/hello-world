
import javax.swing.JOptionPane;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author jrago
 */
public class DMITStudentsUser {
        public static void main(String[]args){
        int menu=0;//main menu page

        do{int choiceMain = Integer.parseInt(
                JOptionPane.showInputDialog
        (null, "Enter your option: \n"
             + " \n"
             + "1. Display Students \n"
             + "2. Search Student \n"
             + "3. Delete Student \n"
             + "4. Add New Student \n"
             + "5. Exit", "DMIT Students", JOptionPane.QUESTION_MESSAGE));//Input Page selection
         
        switch(choiceMain){
            case 1:
                menu=1;
                DMITStudents.displayStudents();
                break;//Page 1
            case 2:
                menu=2;
                DMITStudents.searchStudent();
                break;//Page 2
            case 3:
                menu=3;
                DMITStudents.deleteStudent();
                break;//Page 3
            case 4:
                menu=4;
                DMITStudents.addStudent();
                break;//Page 4
            case 5:
                menu=5;
                JOptionPane.showMessageDialog(null,"Program Terminated.\n"+"Thank You!","Message",JOptionPane.INFORMATION_MESSAGE);
                break;//Page 5
            default:
                menu=0;
                JOptionPane.showMessageDialog(null,
                        "Invalid option! Please enter in the range from 1 to 5.",
                        "Error", JOptionPane.ERROR_MESSAGE);
                break;//Error msg for wrong input
                
            }
        }while(menu<5);
        //return menu;
    }//End of Main Menu
}//End of Class