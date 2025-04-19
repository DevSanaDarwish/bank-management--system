using System;
using System.Data;
using System.Runtime.CompilerServices;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class TransferLogs
    {
        public int transferLogID { get; set; }
        public DateTime date { get; set; }
        public decimal amount { get; set; }
        public decimal sourceBalance { get; set; }
        public decimal destinationBalance { get; set; }
        public int userID { get; set; }
        public int sourceClientID { get; set; }
        public int destinationClientID { get; set; }

        public TransferLogs()
        {
            this.transferLogID = -1;
            this.date = DateTime.Now;
            this.amount = 0;
            this.sourceBalance = 0;
            this.destinationBalance = 0;
            this.userID = -1;
            this.sourceClientID = -1;
            this.destinationClientID = -1;
        }

        public TransferLogs(int transferLogID, DateTime date, decimal amount, decimal sourceBalance, decimal destinationBalance,
            int userID, int sourceClientID, int destinationClientID)
        {
            this.transferLogID = transferLogID;
            this.date = date;
            this.amount = amount;
            this.sourceBalance = sourceBalance;
            this.destinationBalance = destinationBalance;
            this.userID = userID;
            this.sourceClientID = sourceClientID;
            this.destinationClientID = destinationClientID;
        }

        public static DataTable GetTransferLogsList()
        {
            return TransferLogsData.GetTransferLogsList();
        }

        public bool AddTransferLog()
        {
            this.transferLogID = TransferLogsData.AddTransferLog(this.date, this.sourceClientID, this.destinationClientID,
                this.amount, this.sourceBalance, this.destinationBalance, this.userID);

            return (transferLogID != -1);
        }

   
    }
}
