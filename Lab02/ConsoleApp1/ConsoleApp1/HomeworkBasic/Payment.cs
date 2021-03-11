using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.HomeworkBasic
{
    public class Payment : IBuyTicket
    {
        private double walet { get; set; }
        private int tickets;
        public string BuyTicket()
        {
            if (walet > 10) {
                walet -= 10;
                tickets++;
                return "Bilet zostal zakupiony";
            }
            return "Nie masz dość kasy";
        }
        public string SellTicket()
        {
            if (tickets == 0) return "Nie masz biletów do sprzedania";
            walet += 10;
            tickets--;
            return "Bilet zostal sprzedany";
        }
    }
}
