using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class PaymentDao:BaseDao
    {
        public void PaymentHistory(Payment payment)
        {
            conn.Open();
            SqlCommand command = new SqlCommand
                (
             "INSERT INTO PaymentHistory (PaymentMethod,TotalAmount,Tip,Feedback,TableNumber) VALUES (@PaymentMethod, @TotalAmount, @Tip, @Feedback, @TableNumber);SELECT SCOPE_IDENTITY(); ", conn);// 
                                     //"INSERT INTO Drinks (Name, Price, AmountInStock, IsAlcoholic) VALUES (@Name, @Price, @Amount, @IsAlcoholic); SELECT SCOPE_IDENTITY();", conn);


            // Preventing SQL injections
            command.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
            command.Parameters.AddWithValue("@TotalAmount", payment.TotalAmount);
            command.Parameters.AddWithValue("@Tip", payment.TipAmount);
            command.Parameters.AddWithValue("@Feedback", payment.feedBack);
            command.Parameters.AddWithValue("@TableNumber", payment.tableNumber);


            int nrOfRowsAffected = command.ExecuteNonQuery(); // checking if anything was added
            // Convert the enum to an integer and set the parameter value
            if (nrOfRowsAffected == 0)
                throw new Exception("Payment was not completed!");
            command.ExecuteNonQuery();
            conn.Close();

        }

        public List<Payment> GetPayment()  // getting data from database 
        {
            string query = "Select PaymentMethod,TotalAmount,Tip,Feedback,TableNumber FROM [PaymentHistory]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Payment> ReadTables(DataTable dataTable) // data from database into class
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    PaymentMethod = (PaymentMethod)dr["PaymentMethod"],
                    TotalAmount = (decimal)dr["TotalAmount"],
                    TipAmount = (decimal)dr["Tip"],
                    feedBack = dr["Feedback"].ToString(),
                    tableNumber = (int)dr["TableNumber"],   
                };
                payments.Add(payment);
            }
            return payments;
        }
    }
}

