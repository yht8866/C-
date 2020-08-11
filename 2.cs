using System;

namespace ConsoleApp1
{
    public class Money
    {
        public string Category; //区分名
        public string Subject;  //科目名
        public int Previous;    //前期金額
        public int Current;     //当期金額
        public int Balance;     //差額
        static int sumP;        //前期金額の合計
        static int sumC;        //当期金額の合計
        public int sumB;        //合計の差額

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

        public void Output2(string Category, int Previous, int Current, bool output)
        {
            sumP = sumP + Previous; //前期金額の合計
            sumC = sumC + Current;  //当期金額の合計

            if (output)
            {
                //差額算出
                sumB = sumC - sumP; //当期金額の合計 - 前期金額の合計

                //フォーマット変換
                string strP = String.Format("{0:#,0}", sumP);  //前期金額の合計
                string strC = String.Format("{0:#,0}", sumC);  //当期金額の合計
                string strB = String.Format("{0:#,0}", sumB);  //合計の差額

                //データ出力
                Console.WriteLine("{0} {1} {2}", Category, strP, strC); // 区分名、前期金額の合計、当期金額の合計を1行で出力
                Console.WriteLine("{0} {1}", Category, strB);           // 区分名、(当期金額の合計 - 前期金額の合計)を1行で出力
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool output = false;

            Money[] M = new Money[2];
            for (int i = 0; i < 2; i++)
            {
                M[i] = new Money();
            }

            M[0].Category = "流動資産";
            M[0].Previous = 4564255;
            M[0].Current = 5160507;

            M[1].Category = "流動資産";
            M[1].Previous = 2013110;
            M[1].Current = 2525653;

            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    output = true;
                }
                M[i].Output2(M[i].Category, M[i].Previous, M[i].Current, output);
            }
        }
    }
}
