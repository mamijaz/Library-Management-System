using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Library_Management
{
    class Library_Management
    {
        //code for login starts

        public SqlDataReader Log_In(string User_Name,string Password)
        {
            String sql = "SELECT Login.Staff_NIC,Staff.Staff_Name,Login.User_Level FROM Login INNER JOIN Staff ON Login.Staff_NIC=Staff.Staff_NIC WHERE User_Name='" + User_Name + "' AND Password='" + Password + "'";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

       public static string Staff_NIC;
       public static string Staff_Name ;

        //code for login ends

        //code for user registration statrts

        public SqlDataReader Get_Staff_NIC()
        {
            String sql = "SELECT Staff_NIC FROM Staff";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        public SqlDataReader Check_Is_User_NIC_In_Use (string Staff_NIC)
        {
            String sql = "SELECT Staff_NIC FROM Login WHERE Staff_NIC='" + Staff_NIC + "'";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        public SqlDataReader Check_Is_User_Name_A_Staff(string Staff_NIC)
        {
            String sql = "SELECT Staff_NIC FROM Staff WHERE Staff_NIC='" + Staff_NIC + "'";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        public SqlDataReader Check_Is_User_Name_In_Use(string User_Name)
        {
            String sql = "SELECT User_Name FROM Login WHERE User_Name='" + User_Name + "'";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        public void Insert_User(string Staff_NIC,string User_Name,string Password,string User_Level,string Security_Question,string Answer)
        {
            String sql = "INSERT INTO Login VALUES ('" + Staff_NIC + "','" + User_Name + "','" + Password + "','" + User_Level + "','" + Security_Question + "','" + Answer + "')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        //code for user registration ends

        //code for change password starts

        public void Change_Pasword(string User_Name, string Password)
        {
            String sql = "UPDATE Login SET Password='" + Password + "' WHERE User_Name='" + User_Name + "'";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        //code for change password ends

        //code for reset pasword starts

        public SqlDataReader Check_For_Account_Password_Reset(string User_Name, string Security_Question, string Answer)
        {
            String sql = "SELECT User_Name FROM Login WHERE User_Name='" + User_Name + "' AND Security_Question='" + Security_Question + "' AND Answer='" + Answer + "'";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        //code for reset pasword ends

        //code for staff starts

        public void Insert_Staff(string Staff_NIC, string Staff_Name, string Staff_Post, string Staff_Address_Line_1, string Staff_Address_Line_2, string Staff_Address_Line_3, int Staff_Contact_No, string Staff_Section)
        {
            String sql = "INSERT INTO Staff VALUES ('" + Staff_NIC + "','" + Staff_Name + "','" + Staff_Post + "','" + Staff_Address_Line_1 + "','" + Staff_Address_Line_2 + "','" + Staff_Address_Line_3 + "',"+Staff_Contact_No+",'"+Staff_Section+"')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Staff(string Staff_NIC, string Staff_Name, string Staff_Post, string Staff_Address_Line_1, string Staff_Address_Line_2, string Staff_Address_Line_3, int Staff_Contact_No, string Staff_Section)
        {
            String sql = "UPDATE Staff SET Staff_Name='" + Staff_Name + "',Staff_Post='" + Staff_Post + "',Staff_Address_Line_1='" + Staff_Address_Line_1 + "',Staff_Address_Line_2='" + Staff_Address_Line_2 + "',Staff_Address_Line_3='" + Staff_Address_Line_3 + "',Staff_Contact_No=" + Staff_Contact_No + ",Staff_Section='" + Staff_Section + "' WHERE Staff_NIC='" + Staff_NIC + "'";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }
        public SqlDataReader Get_Staff(string Staff_NIC)
        {
            String sql = "SELECT * FROM Staff WHERE Staff_NIC='"+Staff_NIC+"' ";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        //code for staff ends

        //code For Books Starts

        public int Find_Book_Id()
        {
            String sql = "SELECT MAX(Book_Id) FROM Books";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            Int32 Count = (Int32)com.ExecuteScalar();
            Count++;
            return Count;
        }

        public SqlDataReader Get_Catagorys()
        {
            String sql = "SELECT * FROM Book_Catagory";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        public DataSet List_Books()
        {
            DataSet ds = new DataSet();
            String sql = "SELECT * FROM Books ORDER BY Book_Id DESC ";
            SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
            da.Fill(ds, "Books");
            return ds;
        }

        public void Insert_Book(int Book_Id, float Book_Catagory_No, string Book_Section, string Book_Title, string Book_Author, string Book_Publisher, string Book_Publis_Place, float Book_Price, DateTime Book_Recived_Date, int No_Of_Pages, string Book_Source)
        {
            String sql = "INSERT INTO Books VALUES (" + Book_Id + "," + Book_Catagory_No + ",'" + Book_Section + "','" + Book_Title + "','" + Book_Author + "','" + Book_Publisher + "','" + Book_Publis_Place + "'," + Book_Price + ",'" + Book_Recived_Date + "'," + No_Of_Pages + ",'" + Book_Source + "')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();

            String sql2 = "INSERT INTO Book_Status VALUES(" + Book_Id + ",'Yes')";
            SqlCommand Com2 = new SqlCommand(sql2, Connect.Connection());
            Com2.ExecuteNonQuery();
        }

        public SqlDataReader Find_Book(int Book_Id)
        {
            String sql = "SELECT * FROM Books WHERE Book_Id=" + Book_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader book = com.ExecuteReader();
            return book;
        }
        public void Update_Book(int Book_Id, float Book_Catagory_No, string Book_Section, string Book_Title, string Book_Author, string Book_Publisher, string Book_Publish_Place, float Book_Price, DateTime Book_Recived_Date, int No_Of_Pages, string Book_Source)
        {
            String sql = "UPDATE Books SET Book_Catagory_No=" + Book_Catagory_No + ",Book_Section='" + Book_Section + "',Book_Title ='" + Book_Title + "',Book_Author='" + Book_Author + "',Book_Publisher='" + Book_Publisher + "', Book_Publish_Place ='" + Book_Publish_Place + "',Book_Price=" + Book_Price + ",Book_Recived_Date='" + Book_Recived_Date + "',No_Of_Pages=" + No_Of_Pages + ",Book_Source='" + Book_Source + "' WHERE Book_Id="+Book_Id+"";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        //codes for book ends

        //code for catagory starts

        public DataSet List_Book_Catagory()
        {
            DataSet ds = new DataSet();
            String sql = "SELECT * FROM Book_Catagory";
            SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
            da.Fill(ds, "Book_Catagory");
            return ds;
        }

        public DataSet List_Book_For_Catagory(double Book_Catagory_No)
        {
            DataSet ds = new DataSet();
            String sql = "SELECT * FROM Books WHERE Book_Catagory_No=" + Book_Catagory_No + " ORDER BY Book_Id DESC";
            SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection()); 
            da.Fill(ds, "Book_For_Catagory");
            return ds;
        }

        public void Insert_Book_Catagory(double Book_Catagory_No, string Book_Catagory_Name)
        {
            String sql = "INSERT INTO Book_Catagory VALUES (" + Book_Catagory_No + ",'" + Book_Catagory_Name + "')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public SqlDataReader Find_Book_Catagory(double Book_Catagory_No)
        {
            String sql = "SELECT * FROM Book_Catagory WHERE Book_Catagory_No=" + Book_Catagory_No + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader book = com.ExecuteReader();
            return book;
        }

        public void Update_Book_Catagory(double Book_Catagory_No, string Book_Catagory_Name)
        {
            String sql = "Update  Book_Catagory SET Book_Catagory_Name='" + Book_Catagory_Name + "' WHERE Book_Catagory_No=" + Book_Catagory_No + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }
        //code fo catagory ends

        //code For  Member Starts

        public int Find_Member_Id()
        {
            String sql = "SELECT MAX(Member_Id) FROM Members_Basic;";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            Int32 Count = (Int32)com.ExecuteScalar();
            Count++;
            return Count;
        }

        public void Insert_Members_Basic(int Member_Id, string Full_Name, string Address_Line_1, string Address_Line_2, string Address_Line_3, string NIC, DateTime DOB, DateTime Date_Of_Membership, string Member_Type)
        {
            String sql = "INSERT INTO Members_Basic VALUES (" + Member_Id + ",'" + Full_Name + "','" + Address_Line_1 + "','" + Address_Line_2 + "','" + Address_Line_3 + "','" + NIC + "','" + DOB + "','" + Date_Of_Membership + "','" + Member_Type + "')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Member_Contact(int Member_Id, int Member_Mobile, int Member_Home, int Member_Office)
        {
            String sql = "INSERT INTO Member_Contact VALUES (" + Member_Id + ","+Member_Mobile+","+Member_Home+","+Member_Office+")";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Member_Contact(int Member_Id, int Member_Mobile)
        {
            String sql = "INSERT INTO Member_Contact(Member_Id,Member_Mobile) VALUES (" + Member_Id + "," + Member_Mobile + ")";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }
        public void Insert_Job_Details(int Member_Id, string Job, string Workplace_Name, string Workplace_Address_Line_1, string Workplace_Address_Line_2, string Workplace_Address_Line_3)
        {
            String sql = "INSERT INTO Job_Details VALUES (" + Member_Id + ",'"+Job+"','" + Workplace_Name + "','" + Workplace_Address_Line_1 + "','" + Workplace_Address_Line_2 + "','"+Workplace_Address_Line_3+"')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Tax_Payer(int Member_Id, string Tax_Payer_Full_Name, string Tax_Payer_NIC, string Tax_Payer_Address_Line_1, string Tax_Payer_Address_Line_2, string Tax_Payer_Address_Line_3, string Relationship_To_Tax_Payer)
        {
            String sql = "INSERT INTO Tax_Payer VALUES (" + Member_Id + ",'" + Tax_Payer_Full_Name + "','" + Tax_Payer_NIC + "','" + Tax_Payer_Address_Line_1 + "','" + Tax_Payer_Address_Line_2 + "','"+Tax_Payer_Address_Line_3+"','"+Relationship_To_Tax_Payer+"')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Member_Parent(int Member_Id, string Parent_Name, string Parent_Address_Line_1, string Parent_Address_Line_2, string Parent_Address_Line_3, int Contact_No)
        {
            String sql = "INSERT INTO Member_Parent VALUES (" + Member_Id + ",'" + Parent_Name + "','" + Parent_Address_Line_1 + "','" + Parent_Address_Line_2 + "','" + Parent_Address_Line_3 + "',"+ Contact_No + ")";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Member_Division(int Member_Id, string GS_Division, string Divisional_Secreteriat)
        {
            String sql = "INSERT INTO Member_Division VALUES (" + Member_Id + ",'" + GS_Division + "','" + Divisional_Secreteriat + "')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Member_School(int Member_Id, string School_Name, string Class)
        {
            String sql = "INSERT INTO Member_School VALUES (" + Member_Id + ",'" + School_Name + "','" + Class + "')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Member_Urban(int Member_Id, string Urban_Division, string Road_Name)
        {
            String sql = "INSERT INTO Member_Urban VALUES (" + Member_Id + ",'" + Urban_Division + "','" + Road_Name + "')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Insert_Membership_Status(int Member_Id)
        {
            String sql = "INSERT INTO Membership_Status VALUES(" + Member_Id + ",'Active')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Charge_Membership_Fee(int Member_Id, DateTime Date, double Registration_Fee, int Recipt_No)
        {
            String sql = "INSERT INTO Membership_Registration_Fee VALUES(" + Member_Id + ",'"+Date+"',"+Registration_Fee+",'"+Staff_NIC+"',"+Recipt_No+")";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public SqlDataReader Find_Members_Basic(int Member_Id)
        {
            String sql = "SELECT * FROM Members_Basic WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public SqlDataReader Find_Member_Contact(int Member_Id)
        {
            String sql = "SELECT * FROM Member_Contact WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public SqlDataReader Find_Job_Details(int Member_Id)
        {
            String sql = "SELECT * FROM Job_Details WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public SqlDataReader Find_Tax_Payer(int Member_Id)
        {
            String sql = "SELECT * FROM Tax_Payer WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public SqlDataReader Find_Member_Parent(int Member_Id)
        {
            String sql = "SELECT * FROM Member_Parent WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public SqlDataReader Find_Member_Division(int Member_Id)
        {
            String sql = "SELECT * FROM Member_Division WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public SqlDataReader Find_Member_School(int Member_Id)
        {
            String sql = "SELECT * FROM Member_School WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public SqlDataReader Find_Member_Urban(int Member_Id)
        {
            String sql = "SELECT * FROM Member_Urban WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader member = com.ExecuteReader();
            return member;
        }

        public void Update_Members_Basic(int Member_Id, string Full_Name, string Address_Line_1, string Address_Line_2, string Address_Line_3, string NIC, DateTime DOB, DateTime Date_Of_Membership, string Member_Type)
        {
            String sql = "UPDATE Members_Basic SET Full_Name='" + Full_Name + "',Address_Line_1='" + Address_Line_1 + "',Address_Line_2='" + Address_Line_2 + "',Address_Line_3='" + Address_Line_3 + "', NIC='" + NIC + "',Age='" + DOB + "', Membership_Date='" + Date_Of_Membership + "',Member_Type='" + Member_Type + "' WHERE Member_Id=" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Member_Contact(int Member_Id, int Member_Mobile, int Member_Home, int Member_Office)
        {
            String sql = "UPDATE Member_Contact SET Member_Mobile=" + Member_Mobile + ", Member_Home=" + Member_Home + ",Member_Office=" + Member_Office + " WHERE Member_Id =" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Member_Contact(int Member_Id, int Member_Mobile)
        {
            String sql = "UPDATE Member_Contact SET Member_Mobile=" + Member_Mobile + " WHERE Member_Id=" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Job_Details(int Member_Id, string Job, string Workplace_Name, string Workplace_Address_Line_1, string Workplace_Address_Line_2, string Workplace_Address_Line_3)
        {
            String sql = "UPDATE Job_Details SET Job='" + Job + "',Workplace_Name='" + Workplace_Name + "',Workplace_Address_Line_1='" + Workplace_Address_Line_1 + "',Workplace_Address_Line_2='" + Workplace_Address_Line_2 + "',Workplace_Address_Line_3='" + Workplace_Address_Line_3 + "' WHERE Member_Id=" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Tax_Payer(int Member_Id, string Tax_Payer_Full_Name, string Tax_Payer_NIC, string Tax_Payer_Address_Line_1, string Tax_Payer_Address_Line_2, string Tax_Payer_Address_Line_3, string Relationship_To_Tax_Payer)
        {
            String sql = "UPDATE Tax_Payer SET Tax_Payer_Full_Name='" + Tax_Payer_Full_Name + "',Tax_Payer_NIC='" + Tax_Payer_NIC + "',Tax_Payer_Address_Line_1='" + Tax_Payer_Address_Line_1 + "',Tax_Payer_Address_Line_2='" + Tax_Payer_Address_Line_2 + "',Tax_Payer_Address_Line_3='" + Tax_Payer_Address_Line_3 + "',Relationship_To_Tax_Payer='" + Relationship_To_Tax_Payer + "' WHERE Member_Id=" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Member_Parent(int Member_Id, string Parent_Name, string Parent_Address_Line_1, string Parent_Address_Line_2, string Parent_Address_Line_3, int Contact_No)
        {
            String sql = "UPDATE Member_Parent SET Parent_Name='" + Parent_Name + "',Parent_Address_Line_1='" + Parent_Address_Line_1 + "',Parent_Address_Line_2='" + Parent_Address_Line_2 + "',Parent_Address_Line_3='" + Parent_Address_Line_3 + "',Contact_No=" + Contact_No + " WHERE Member_Id=" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Member_Division(int Member_Id, string GS_Division, string Divisional_Secreteriat)
        {
            String sql = "UPDATE Member_Division SET GS_Division='" + GS_Division + "',Divisional_Secreteriat='" + Divisional_Secreteriat + "' WHERE Member_Id=" + Member_Id + " ";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        public void Update_Member_School(int Member_Id, string School_Name, string Class)
        {
            String sql = "UPDATE Member_School SET School_Name='" + School_Name + "',Class='" + Class + "' WHERE Member_Id=" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }
        public void Update_Member_Urban(int Member_Id, string Urban_Division, string Road_Name)
        {
            String sql = "UPDATE Member_Urban SET Urban_Division='" + Urban_Division + "',Road_Name='" + Road_Name + "' WHERE  Member_Id=" + Member_Id + "";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();
        }

        //code for member ends

        //code for lending starts

        public SqlDataReader Find_Circulation_No()
        {
            String sql = "SELECT MAX(Circulation_No) FROM Lending;";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }
        public SqlDataReader Find_Book_Status(int Book_Id)
        {
            String sql = "SELECT Book_Status FROM Book_Status WHERE Book_Id="+Book_Id+" ;";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader Count = com.ExecuteReader();
            return Count;
        }

        public void Set_Membership_Status(int Member_Id, DateTime Membership_Date)
        {
            DateTime Current_Date = DateTime.Now;
            if (((Current_Date - Membership_Date).Days) > 365)
            {
                String sql = "UPDATE Membership_Status SET Member_Status='Inactive' WHERE  Member_Id=" + Member_Id + "";
                SqlCommand Com = new SqlCommand(sql, Connect.Connection());
                Com.ExecuteNonQuery();
            }
        }

        public SqlDataReader Find_Membership_Status(int Member_Id)
        {
            String sql = "SELECT Member_Status FROM Membership_Status WHERE Member_Id=" + Member_Id + "";
            SqlCommand com = new SqlCommand(sql, Connect.Connection());
            SqlDataReader status = com.ExecuteReader();
            return status;
        }

        public void Lend_Books(int Circulation_No, int Member_Id, int Book_Id, DateTime Lending_Date)
        {
            String sql = "INSERT INTO Lending VALUES(" + Circulation_No + "," + Member_Id + "," + Book_Id + ",'" + Lending_Date + "','No','"+Staff_NIC+"')";
            SqlCommand Com = new SqlCommand(sql, Connect.Connection());
            Com.ExecuteNonQuery();

            String sql2 = "UPDATE Book_Status SET Book_Status='No' WHERE Book_Id=" + Book_Id + "";
            SqlCommand Com2 = new SqlCommand(sql2, Connect.Connection());
            Com2.ExecuteNonQuery();
        }
       public DataSet List_Of_Lended_Books(int Member_Id)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Lending.Circulation_No,Lending.Book_Id,Books.Book_Catagory_No,Books.Book_Title,Lending.Status FROM Lending INNER JOIN Books ON Lending.Book_Id=Books.Book_Id WHERE Member_Id=" + Member_Id + " ORDER BY Circulation_No DESC";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Lended Book Details");
           return ds;
       }
       public int Find_No_Book_To_Returned(int Member_Id)
       {
           String sql = " SELECT COUNT (*) FROM Lending WHERE Member_Id=" + Member_Id + " AND Status='No' ";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           Int32 Count = (Int32)com.ExecuteScalar();
           return Count;
       }

        //code for lending ends

        //code for return starts

       public SqlDataReader Find_Lended_Details(int Circulation_No)
       {
           String sql = "SELECT * FROM Lending WHERE Circulation_No=" + Circulation_No + "";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader details = com.ExecuteReader();
           return details;
       }

       public DataSet List_Of_Books_To_Be_Returned()
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Lending.Circulation_No,Lending.Book_Id,Books.Book_Catagory_No,Books.Book_Title,Lending.Member_Id,Members_Basic.Full_Name,Lending.Lending_Date FROM Lending INNER JOIN Books ON Lending.Book_Id=Books.Book_Id INNER JOIN Members_Basic ON Lending.Member_Id=Members_Basic.Member_Id WHERE Status='No' ORDER BY Lending.Book_Id DESC";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Lended Book Details");
           return ds;
       }
       public double Find_Late_Fine(DateTime Lending_Date, DateTime Return_Date)
       {
           double days=((Return_Date-Lending_Date).Days);
           double fine;
           if (days <= 21)
           {
               fine = 0;
           }
           else
           {
               fine = (days - 14) * 2.5;
           }
           return fine;
       }
       public void Return_Books(int Circulation_No, int Book_Id, int Member_Id, DateTime Lending_Date, DateTime Return_Date, double Fine_Amount, int Receipt_No)
       {
           String sql = "INSERT INTO [Return] VALUES(" + Circulation_No + "," + Book_Id + "," + Member_Id + ",'" + Lending_Date + "','" + Return_Date + "'," + Fine_Amount + "," + Receipt_No + ",'"+Staff_NIC+"')";
           SqlCommand Com = new SqlCommand(sql, Connect.Connection());
           Com.ExecuteNonQuery();

           String sql2 = "UPDATE Book_Status SET Book_Status='Yes' WHERE Book_Id=" + Book_Id + "";
           SqlCommand Com2 = new SqlCommand(sql2, Connect.Connection());
           Com2.ExecuteNonQuery();

           String sql3 = "UPDATE Lending SET Status='Yes' WHERE Circulation_No=" + Circulation_No + "";
           SqlCommand Com3 = new SqlCommand(sql3, Connect.Connection());
           Com3.ExecuteNonQuery();
       }
        //code for return ends

        //code for lost starts

       public void Lost_Books(int Circulation_No, int Book_Id, int Member_Id, DateTime Lending_Date, DateTime Lost_Date, double Lost_Fine,double Fine_For_Late_Submission,double Binding_Charges,double Total_Charges, int Receipt_No)
       {
           String sql = "INSERT INTO Lost VALUES(" + Circulation_No + "," + Book_Id + "," + Member_Id + ",'" + Lending_Date + "','" + Lost_Date + "'," + Lost_Fine + "," + Fine_For_Late_Submission + "," + Binding_Charges + "," + Total_Charges + "," + Receipt_No + ",'" + Staff_NIC + "')";
           SqlCommand Com = new SqlCommand(sql, Connect.Connection());
           Com.ExecuteNonQuery();

           String sql2 = "UPDATE Book_Status SET Book_Status='Lost' WHERE Book_Id=" + Book_Id + "";
           SqlCommand Com2 = new SqlCommand(sql2, Connect.Connection());
           Com2.ExecuteNonQuery();

           String sql3 = "UPDATE Lending SET Status='Lost' WHERE Circulation_No=" + Circulation_No + "";
           SqlCommand Com3 = new SqlCommand(sql3, Connect.Connection());
           Com3.ExecuteNonQuery();
       }

        //code for lost ends

        //code for multimedia starts
       public void Insert_Outsiders(string Outsider_NIC, string Outsider_Name, string Outsider_Address_Line_1, string Outsider_Address_Line_2, string Outsider_Address_Line_3, int Outsider_Contact)
       {
           String sql = "INSERT INTO Outsider VALUES('" + Outsider_NIC + "','" + Outsider_Name + "','" + Outsider_Address_Line_1 + "','" + Outsider_Address_Line_2 + "','" + Outsider_Address_Line_3 + "',"+Outsider_Contact+")";
           SqlCommand Com = new SqlCommand(sql, Connect.Connection());
           Com.ExecuteNonQuery();
       }
       public SqlDataReader Find_Outsider(string Outsider_NIC)
       {
           String sql = "SELECT * FROM Outsider WHERE Outsider_NIC='" + Outsider_NIC + "'";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader status = com.ExecuteReader();
           return status;
       }
       public void Update_Outsiders(string Outsider_NIC, string Outsider_Name, string Outsider_Address_Line_1, string Outsider_Address_Line_2, string Outsider_Address_Line_3, int Outsider_Contact)
       {
           String sql = "UPDATE Outsider SET Outsider_Name='" + Outsider_Name + "',Outsider_Address_Line_1='" + Outsider_Address_Line_1 + "',Outsider_Address_Line_2='" + Outsider_Address_Line_2 + "',Outsider_Address_Line_3='" + Outsider_Address_Line_3 + "',Outsider_Contact="+Outsider_Contact+" WHERE Outsider_NIC='" + Outsider_NIC + "'";
           SqlCommand Com = new SqlCommand(sql, Connect.Connection());
           Com.ExecuteNonQuery();
       }

       public SqlDataReader Find_Mutimedia_Usage_No()
       {
           String sql = "SELECT MAX(Mutimedia_Usage_No) FROM Multimedia;";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader Count = com.ExecuteReader();
           return Count;
       }
       public void Insert_Charges_For_Multimedia(int Mutimedia_Usage_No, string Outsider_NIC, DateTime Multimedia_Use_Date, DateTime Multimedia_In_Time, DateTime Mutimedia_Out_Time, DateTime Usage_Duration, double Cost, int Recipt_No)
       {
           String sql = "INSERT INTO Multimedia VALUES(" + Mutimedia_Usage_No + ",'" + Outsider_NIC + "','" + Multimedia_Use_Date + "','" + Multimedia_In_Time + "','" + Mutimedia_Out_Time + "','" + Usage_Duration + "',"+Cost+","+Recipt_No+",'"+Staff_NIC+"')";
           SqlCommand Com = new SqlCommand(sql, Connect.Connection());
           Com.ExecuteNonQuery();
       }
       public DataSet Find_Multimedia_Usage_Details(DateTime Multimedia_Use_Date)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Multimedia.Mutimedia_Usage_No,Outsider.Outsider_Name,Multimedia.Multimedia_In_Time,Multimedia.Mutimedia_Out_Time,Multimedia.Usage_Duration,Multimedia.Cost,Multimedia.Recipt_No From Multimedia INNER JOIN Outsider ON Multimedia.Outsider_NIC=Outsider.Outsider_NIC ORDER BY Mutimedia_Usage_No DESC   ";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Uasge For The Day");
           return ds;
       }
        //code for multimedia end

        //code for reference starts

       public SqlDataReader Find_Reference_No()
       {
           String sql = "SELECT MAX(Reference_No) FROM Reference;";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader Count = com.ExecuteReader();
           return Count;
       }

       public SqlDataReader Find_Reference_Details(int Reference_No)
       {
           String sql = "SELECT * FROM Reference WHERE Reference_No='" + Reference_No + "'";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader status = com.ExecuteReader();
           return status;
       }

       public DataSet List_Of_Books_Given_To_Reference()
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Reference.Reference_No,Reference.Date,Reference.Book_Id,Books.Book_Catagory_No,Books.Book_Title,Reference.Outsider_NIC,Outsider.Outsider_Name,Reference.In_Time FROM Reference INNER JOIN Books ON Reference.Book_Id=Books.Book_Id INNER JOIN Outsider ON Reference.Outsider_NIC=Outsider.Outsider_NIC WHERE Out_Time IS NULL ORDER BY Reference_No DESC";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "List_Of_Books_Given_To_Reference");
           return ds;
       }
       public void Give_Books_For_Reference(int Reference_No, DateTime Date, string Outsider_NIC, int Book_Id, DateTime In_Time)
       {
           String sql = "INSERT INTO Reference(Reference_No,Date,Outsider_NIC,Book_Id,In_Time) VALUES(" + Reference_No + ",'" + Date + "','" + Outsider_NIC + "'," + Book_Id + ",'"+In_Time+"')";
           SqlCommand Com = new SqlCommand(sql, Connect.Connection());
           Com.ExecuteNonQuery();

           String sql2 = "UPDATE Book_Status SET Book_Status='No' WHERE Book_Id=" + Book_Id + "";
           SqlCommand Com2 = new SqlCommand(sql2, Connect.Connection());
           Com2.ExecuteNonQuery();
       }
       public void Get_Books_From_Reference(int Reference_No, DateTime Out_Time, int Book_Id)
       {
           String sql = "UPDATE Reference SET Out_Time='" + Out_Time + "' WHERE Reference_No="+Reference_No+"";
           SqlCommand Com = new SqlCommand(sql, Connect.Connection());
           Com.ExecuteNonQuery();

           String sql2 = "UPDATE Book_Status SET Book_Status='Yes' WHERE Book_Id=" + Book_Id + "";
           SqlCommand Com2 = new SqlCommand(sql2, Connect.Connection());
           Com2.ExecuteNonQuery();
       }
        //code for reference end

        //code for search starts

       public DataSet Search_Books_By_Title(string Keyword)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT * FROM Books Where Book_Title LIKE '%"+Keyword+"%'";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Books_By_Title");
           return ds;
       }

       public DataSet Search_Books_By_Author(string Keyword)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT * FROM Books Where Book_Author LIKE '%" + Keyword + "%'";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Books_By_Author");
           return ds;
       }

       public SqlDataReader Find_Who_Has_The_Book(int Book_Id)
       {
           String sql = "SELECT * FROM Lending WHERE Book_Id=" + Book_Id + " AND Status='No' ;";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader Count = com.ExecuteReader();
           return Count;
       }
       public DataSet Find_Who_Have_Used_The_Book(int Book_Id)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Lending.Circulation_No,Lending.Member_Id,Members_Basic.Full_Name,Lending.Lending_Date FROM Lending INNER JOIN Members_Basic ON Lending.Member_Id=Members_Basic.Member_Id WHERE Book_Id=" + Book_Id + " ORDER BY Circulation_No DESC";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Books_Users");
           return ds;
       }


        //code for search ends

        //code for income reports starts
       public SqlDataReader Find_Income_From_Member_Registration(DateTime From, DateTime To)
       {
           String sql = " SELECT SUM(Registration_Fee) FROM Membership_Registration_Fee WHERE Date BETWEEN '"+From+"' AND '"+To+"' ";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader Count = com.ExecuteReader();
           return Count;
       }
       public SqlDataReader Find_Income_From_Return(DateTime From, DateTime To)
       {
           String sql = " SELECT SUM(Fine_Amount) FROM [Return] WHERE Return_Date BETWEEN '" + From + "' AND '" + To + "' ";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader Count = com.ExecuteReader();
           return Count;
       }
       public SqlDataReader Find_Income_From_Lost(DateTime From, DateTime To)
       {
           String sql = " SELECT SUM(Total_Charges) FROM Lost WHERE Lost_Date BETWEEN '" + From + "' AND '" + To + "' ";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader Count = com.ExecuteReader();
           return Count;
       }
       public SqlDataReader Find_Income_From_Multimedia(DateTime From, DateTime To)
       {
           String sql = " SELECT SUM(Cost) FROM Multimedia WHERE Multimedia_Use_Date BETWEEN '" + From + "' AND '" + To + "' ";
           SqlCommand com = new SqlCommand(sql, Connect.Connection());
           SqlDataReader Count = com.ExecuteReader();
           return Count;
       }
       public DataSet View_Income_From_Member_Registration(DateTime From, DateTime To)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Membership_Registration_Fee.Member_Id,Members_Basic.Full_Name,Membership_Registration_Fee.Registration_Fee,Staff.Staff_Name,Membership_Registration_Fee.Staff_NIC,Membership_Registration_Fee.Recipt_No FROM Membership_Registration_Fee INNER JOIN Members_Basic ON Membership_Registration_Fee.Member_Id=Members_Basic.Member_Id INNER JOIN Staff ON Membership_Registration_Fee.Staff_NIC=Staff.Staff_NIC WHERE Date BETWEEN '" + From + "' AND '" + To + "'";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Report");
           return ds;
       }

       public DataSet View_Income_From_Book_Return(DateTime From, DateTime To)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT [Return].Circulation_No,[Return].Fine_Amount,[Return].Receipt_No,Staff.Staff_Name,[Return].Staff_NIC FROM [Return] INNER JOIN Staff ON [Return].Staff_NIC=Staff.Staff_NIC WHERE Return_Date BETWEEN '" + From + "' AND '" + To + "'";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Report");
           return ds;
       }

       public DataSet View_Income_From_Book_Lost(DateTime From, DateTime To)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Lost.Circulation_No,Lost.Total_Charges,Lost.Receipt_No,Staff.Staff_Name,Lost.Staff_NIC FROM Lost INNER JOIN Staff ON Lost.Staff_NIC=Staff.Staff_NIC WHERE Lost_Date BETWEEN '" + From + "' AND '" + To + "'";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Report");
           return ds;
       }
       public DataSet View_Income_From_Multomedia(DateTime From, DateTime To)
       {
           DataSet ds = new DataSet();
           String sql = "SELECT Multimedia.Mutimedia_Usage_No,Outsider.Outsider_Name,Multimedia.Outsider_NIC,Multimedia.Usage_Duration,Multimedia.Cost,Staff.Staff_Name,Multimedia.Staff_NIC,Multimedia.Recipt_No FROM Multimedia INNER JOIN Staff ON Multimedia.Staff_NIC=Staff.Staff_NIC INNER JOIN Outsider ON Multimedia.Outsider_NIC=Outsider.Outsider_NIC WHERE Multimedia_Use_Date BETWEEN '" + From + "' AND '" + To + "'";
           SqlDataAdapter da = new SqlDataAdapter(sql, Connect.Connection());
           da.Fill(ds, "Report");
           return ds;
       }
        //code for income reports ends
    }
}
