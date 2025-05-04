using System;
using System.Data;
using System.Runtime.CompilerServices;
using BankSystemDataAccessLayer;

namespace BankSystemBusinessLayer
{
    public class TransferLogs
    {
        public int TransferLogID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal SourceBalance { get; set; }
        public decimal DestinationBalance { get; set; }
        public int UserID { get; set; }
        public int SourceClientID { get; set; }
        public int DestinationClientID { get; set; }

        public TransferLogs()
        {
            this.TransferLogID = -1;
            this.Date = DateTime.Now;
            this.Amount = 0;
            this.SourceBalance = 0;
            this.DestinationBalance = 0;
            this.UserID = -1;
            this.SourceClientID = -1;
            this.DestinationClientID = -1;
        }

        public static DataTable GetTransferLogsList()
        {
            return TransferLogsData.GetTransferLogsList();
        }

        public bool AddTransferLog()
        {
            this.TransferLogID = TransferLogsData.AddTransferLog(this.Date, this.SourceClientID, this.DestinationClientID,
                this.Amount, this.SourceBalance, this.DestinationBalance, this.UserID);

            return (TransferLogID != -1);
        }
    }
}
