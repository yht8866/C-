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

            Money[] M1 = new Money[2];
            for (int i = 0; i < 2; i++)
            {
                M1[i] = new Money();
            }

            Money[] M2 = new Money[2];
            for (int j = 0; j < 2; j++)
            {
                M2[j] = new Money();
            }

            M1[0].Category = "資産の部";
            M1[0].Previous = 7277553;
            M1[0].Current  = 8398467;

            M2[0].Category = "資産の部";
            M2[0].Previous = 1536737;
            M2[0].Current  = 2016762;

            for (int i = 0; i < 1; i++)
            {
                M1[i].Output2(M1[i].Category, M1[i].Previous, M1[i].Current, output);
            }

            for (int j = 0; j < 1; j++)
            {
                if (j == 0)
                {
                    output = true;
                }
                M2[j].Output2(M2[j].Category, M2[j].Previous, M2[j].Current, output);
            }
        }
    }
}
