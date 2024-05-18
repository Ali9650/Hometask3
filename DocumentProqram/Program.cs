namespace DocumentProqram
{
    internal class Program
    {
        
        static void Main()
        {
        InputKeyDesc: Console.WriteLine("Key daxil edin");
        string key = Console.ReadLine();
    
                switch (key)
                {
                   case "Basic":
                        DocumentProqram documentProqram = new DocumentProqram();
                        documentProqram.OpenDocument();
                        documentProqram.EditDocument();
                        documentProqram.SaveDocument("cs");
                        break;
                    case "Pro":
                        ProDocumentProqram proDocumentProqram = new ProDocumentProqram();
                        proDocumentProqram.OpenDocument();
                        proDocumentProqram.EditDocument();
                        proDocumentProqram.SaveDocument("xlsx");
                        break;
                    case "Expert":
                        ExpertDocumentProqram expertDocumentProqram = new ExpertDocumentProqram();
                        expertDocumentProqram.OpenDocument();
                        expertDocumentProqram.EditDocument();
                        expertDocumentProqram.SaveDocument("txt");
                        break;
                    default:
                    goto InputKeyDesc;
                    break;
                }     
            }
        }
    }

