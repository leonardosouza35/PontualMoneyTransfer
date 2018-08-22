using System;
using System.Collections.Generic;
using System.Linq;

namespace PontualMoneyTransfer.LogAnalyzer
{
    class Program
    {
        public static List<string> ExceptItemsDia15()
        {
            return new List<string>()
            {
                "172744",		
"172746",
"172773",
"172774",
"172776",
"172777",
"172778",
"172779",
"172826",
"172844",
"172845",
"172846",
"172854",
"172855",
"172856",
"172858",
"172857",
"172859",
"172860",
"172861",
"172862",
"172863",
"172864",
"172865",
"172866",
"172867",
"172868",
"172869",
            };


        }


        public static List<string> ExceptItemsDia14()
        {
            return new List<string>()
            {
                "172273",
"172375",
"172400",
"172404",
"172406",
"172407",
"172474",
"172475",
"172476",
"172477",
"172478",
"172479",
"172480",
"172481",
"172482",
            };

            
        }
        static void Main(string[] args)
        {            
            LogAnalyzer analyzer = new LogAnalyzer(@"C:\Projetos\PontualMoneyTransfer\PontualMoneyTransfer.LogAnalyzer\bin\Debug\log-arquivo-dia-15.txt");
            analyzer.SearchAll("PaymentId:", ExceptItemsDia15());
            var itemsSearched = analyzer.AllItemsSearched;

            Logger logger = new Logger(@"C:\Projetos\PontualMoneyTransfer\PontualMoneyTransfer.LogAnalyzer\bin\Debug\resultado15.txt");
            logger.Write(itemsSearched);

            int notaAluno = 7;
            string resultado = notaAluno >= 7 ? "Aprovado" : "Reprovado";
        }
    }
}
