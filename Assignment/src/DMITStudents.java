
import java.util.Scanner;
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
public class DMITStudents {

        private static String[] nameList={"Grace Teo", "Kenny Tan", "Peter Low"};
        private static String[] courseList={"DIT","DIT","DIT"};
        private static int[] mobileList={91111111,92222222,93333333};
        private static char[] genderList={'F','M','M'};//constructor

    
    public static void displayStudents(){
        String display="";
        for (int  i=0; i < nameList.length; i++ ) {
	display+=((i+1)+"    "+nameList[i]+"   "+genderList[i]+"     "+courseList[i]+"     "+mobileList[i]+"\n");
}//student display

    
    
        JOptionPane.showMessageDialog(null,
                "S/N   Name      Gender   Course    Contact\n"+ display
                
                        ,"DMITStudents",JOptionPane.INFORMATION_MESSAGE);//display message
    }//End of displayStudents
    public static void searchStudent(){
        
        Scanner searchScan = new Scanner(System.in);
        String nameSearch= (JOptionPane.showInputDialog(null,"Please enter student's name to search...","Input",JOptionPane.QUESTION_MESSAGE));
        if(nameList.hasNext(nameSearch)){
        JOptionPane.showMessageDialog(null,"Name:     "+nameSearch+"\n"+"Gender:     "+"\n"+"Course:     "+"\n"+"Mobile:     ","DMIT Students",JOptionPane.INFORMATION_MESSAGE);}
        else{
            JOptionPane.showMessageDialog(null,"Cannot find the info of "+ nameSearch ,"DMIT Students",JOptionPane.INFORMATION_MESSAGE);
        }   
        
        searchscan.close();
    }//End of searchStudent
    public static void deleteStudent(){
        Scanner deleteScan = new Scanner(System.in);
        String nameSearch= (JOptionPane.showInputDialog(null,"Please enter student's name to delete...","Input",JOptionPane.QUESTION_MESSAGE));
        if(nameList.hasNext(nameSearch)){
        JOptionPane.showMessageDialog(null,nameSearch+" has been deleted successfully.",JOptionPane.INFORMATION_MESSAGE);}
        else{
            JOptionPane.showMessageDialog(null,"The student named "+ nameSearch +"cannot be found!","DMIT Students",JOptionPane.ERROR_MESSAGE);
        }   
        
        deletescan.close();
        
        
    }//End of deleteStudent
    public static void addStudent(){
        String name=JOptionPane.showInputDialog(null,"Please enter student's name:","Input",JOptionPane.QUESTION_MESSAGE);
        String course=JOptionPane.showInputDialog(null,"Please enter student's course:","Input",JOptionPane.QUESTION_MESSAGE);
        int mobile=Integer.parseInt(JOptionPane.showInputDialog(null,"Please enter student's mobile:","Input",JOptionPane.QUESTION_MESSAGE));
        String sex=JOptionPane.showInputDialog(null,"Please enter student's gender:","Input",JOptionPane.QUESTION_MESSAGE);
        char gender=sex.charAt(0);
        
    }

    public DMITStudents() {
        this.nameList = new String[]{"Grace Teo", "Kenny Tan", "Peter Low"};
    }
}