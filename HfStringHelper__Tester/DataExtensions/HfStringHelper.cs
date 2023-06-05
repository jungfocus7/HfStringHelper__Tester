using System.Text;




namespace HfStringHelper__Tester.DataExtensions
{
    public static class HfStringHelper
    {
/*
        char tc = default;      //'\0'
        string ts = default;    //null
        int tn = default;       //0
        float tf = default;     //0
        double td = default;    //0
        long tl = default;      //0
        */



        /// <summary>
        /// 문자열에서 순서대로 숫자만 추출
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string GetSeqNumStr(this string target)
        {
            if (string.IsNullOrWhiteSpace(target))
                return string.Empty;

            StringBuilder tsb = new StringBuilder();
            foreach (char tc in target)
            {
                if (char.IsDigit(tc))
                    tsb.Append(tc);
            }

            return tsb.ToString();
        }


        /// <summary>
        /// 문자열에서 순서대로 숫자만 추출 (int)
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int GetSeqNum(this string target)
        {
            string ns = GetSeqNumStr(target);
            if (int.TryParse(ns, out int rn))
                return rn;
            else
                return default;
        }

    }

}
