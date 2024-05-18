

namespace DocumentProqram 
{
    internal class ProDocumentProqram : DocumentProqram
    {
       public sealed override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }    

        public override void SaveDocument (string format)
        {
            if (format == "doc") 
            {
                Console.WriteLine("Document Saved in doc format");
            }
            else if (format == "pdf")
            {
                Console.WriteLine("Document Saved  for pdf format buy Expert packet");
            }
            else
            {
                Console.WriteLine("Format is invalid");
            }
           
        }
    }
}