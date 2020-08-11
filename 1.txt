using System;

namespace ConsoleApp1
{
    public class Money
    {
        public string Subject; //科目名
        public int Previous;   //前期金額
        public int Current;    //当期金額
        public int Balance;    //差額

        public Money()
        {
        }

        public void Output1(string Subject, int Previous, int Current)
        {
            //差額算出
            Balance = Current - Previous; //当期金額 - 前期金額

            //フォーマット変換
            string strP = String.Format("{0:#,0}", Previous); //前期金額
            string strC = String.Format("{0:#,0}", Current);  //当期金額
            string strB = String.Format("{0:#,0}", Balance);  //当期金額 - 前期金額

            //データ出力
            Console.WriteLine("{0} {1} {2}", Subject, strP, strC); // 全てのデータを1行で出力
            Console.WriteLine("{0} {1}", Subject, strB);           // 科目名、(当期金額 - 前期金額)を1行で出力
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money M1 = new Money
            {
                Subject = "現金及び預金",
                Previous = 4564255,
                Current = 5160507
            };

            M1.Output1(M1.Subject, M1.Previous, M1.Current);
        }
    }
}
