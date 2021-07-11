using System;

namespace CompDNA
{
    public class DnaStrand 
    {
        public static void Main(string[] args)
        {
            DnaStrandTest.TestCase("AAAA", DnaStrand.MakeComplement("TTTT"));
            DnaStrandTest.TestCase("ATTGC", DnaStrand.MakeComplement("TAACG"));
            DnaStrandTest.TestCase("GTAT", DnaStrand.MakeComplement("CATA"));
            DnaStrandTest.TestCase("AAGG", DnaStrand.MakeComplement("TTCC"));
            DnaStrandTest.TestCase("CGCG", DnaStrand.MakeComplement("GCGC"));
            DnaStrandTest.TestCase("ATTGC", DnaStrand.MakeComplement("TAACG"));
            DnaStrandTest.TestCase("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", DnaStrand.MakeComplement("CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT"));
        }
        public static string MakeComplement(string dna)
        {
            //Your code
            char[] dnaArr = dna.ToCharArray();
            char[] _T = "TT".ToCharArray();
            char[] _A = "AA".ToCharArray();
            char[] _G = "GG".ToCharArray();
            char[] _C = "CC".ToCharArray();
            int dnaLen = dnaArr.Length;
            
            for (int i = 0; i < dnaLen; i++) {
                if (dnaArr[i].ToString() == "A") {
                dnaArr[i] = _T[0];
                } else if (dnaArr[i].ToString() == "T") {
                dnaArr[i] = _A[0];
                } else if (dnaArr[i].ToString() == "G") {
                dnaArr[i] = _C[0];
                } else if (dnaArr[i].ToString() == "C") {
                dnaArr[i] = _G[0];
                }
            }

            return string.Join("", dnaArr);
        }
    }

    public class DnaStrandTest
    {
        public static void TestCase(string a, string b)
        {
            if (a == b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}