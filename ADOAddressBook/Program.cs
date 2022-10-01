namespace ADOAddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to contact management program");
            AddressBookADO Book = new AddressBookADO();

            ShowOptions();

            void ShowOptions()
            {
                Console.WriteLine("\n Select Option :\n1.Display Contacts\n2.Add Contact Details\n3.Add person to a category\n4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Book.GetContactDetails();
                        ShowOptions();
                        break;
                    case 2:
                        Book.AddContact();
                        ShowOptions();
                        break;
                    case 3:
                        Book.AddPersonToCatagory();
                        ShowOptions();
                        break;
                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }
            }       
        }
        
    }

}