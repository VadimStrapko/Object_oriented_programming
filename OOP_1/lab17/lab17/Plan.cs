﻿namespace lab17
{
    public static class Plan
    {
        static List<string> plan = new List<string>();
        
        public static void AddToPlan(string quantity, string typeOfWork)
        {
            //формирование записи с текущей датой/временем, количеством и типом работы
            plan.Add(DateTime.Now.ToString() + " " + quantity + " " + typeOfWork + "\n");
        }
        public static List<string> GetPlan()
        {
            return plan;
        }
    }
}
