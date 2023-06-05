using HfStringHelper__Tester.DataExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace HfStringHelper__Tester
{
    public static class TesterProgram
    {
        public static void Main(string[] args)
        {
            //string nums = "0123456789abcdef";
            //foreach (char tc in nums)
            //{
            //    Console.WriteLine($"char: {tc}, IsDigit: {char.IsDigit(tc)}, IsNumber: {char.IsNumber(tc)}");
            //}

            //string nums = "0123456789abcdef";
            //for (int i = 0; i < int.MaxValue; ++i)
            //{
            //    char tc = (char)i;
            //    if (char.IsDigit(tc) == char.IsNumber(tc))
            //        continue;

            //    string rst = $"char: {tc}, IsDigit: {char.IsDigit(tc)}, IsNumber: {char.IsNumber(tc)}";
            //    Console.WriteLine(rst);
            //}






            string cs = "HB_923_L_72";
            string rs = cs.GetSeqNumStr();
            int rn = cs.GetSeqNum();

            if (int.TryParse(null, out int tn))
            {

            }
        }
    }





}
