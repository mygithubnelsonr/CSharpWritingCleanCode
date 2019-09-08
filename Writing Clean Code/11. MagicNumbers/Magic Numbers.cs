using System;

namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        // the method uses magic numbers which mean number like 1, 2, .. 
        // what is the meaning? 
        public void ApproveDocumentOld(int status)
        {
            if(status == 1)
            {
                // ...
            }
            else if(status == 2)
            {
                // ...
            }
        }

        // we get avoid of that numbers and replace them with an enumeration
        public void ApproveDocument(DocumentStatus status)
        {
            if(status == DocumentStatus.Draft)
            {
                // ...
            }
            else if(status == DocumentStatus.Lodged)
            {
                // ...
            }
        }

        // the same here
        public void RejectDocumentOld(string status)
        {
            switch(status)
            {
                case "1":
                    Console.WriteLine($"RejectDocument={status}");
                    break;
                case "rot":
                    Console.WriteLine($"RejectDocument={status}");
                    break;
            }
        }

        public void RejectDocument(DocumentStatus status)
        {
            switch(status)
            {
                case DocumentStatus.Draft:
                    // ...
                    break;
                case DocumentStatus.Lodged:
                    // ...
                    break;
            }
        }
    }
}
