string file = "ticketData.txt";
string choice;
do{
    Console.WriteLine("1) Read Data from file.");
    Console.WriteLine("2) Create File from data");
    Console.WriteLine("Enter any other key to exit");

    choice = Console.ReadLine();

    if(choice == "1"){
        if(File.Exists(file)){
         
         StreamReader sr = new StreamReader(file);
          
          while(!sr.EndOfStream){

            string newPerson = sr.ReadLine();

            Console.WriteLine(newPerson);
 
          }
          sr.Close();

        }
        else{
            Console.WriteLine("File does not exist");
        }

    } else if (choice == "2"){
        StreamWriter sw = new StreamWriter(file);
        for(int i = 0; i < 7; i++){

            Console.WriteLine("Enter Ticket (Y/N)?");

            string resp = Console.ReadLine().ToUpper();

            if(resp != "Y") { break; }

            Console.WriteLine("Enter ticketID:");

            string ticketID = Console.ReadLine();

            Console.WriteLine("Enter Summary:");

            string Summary = Console.ReadLine();

            Console.WriteLine("Enter Status:");

            string Status = Console.ReadLine();

            Console.WriteLine("Enter priority:");

            string priority = Console.ReadLine();

            Console.WriteLine("Enter Submitter:");

            string Submitter = Console.ReadLine();

            Console.WriteLine("Enter assigend:");

            string assigend = Console.ReadLine();

            Console.WriteLine("Enter watching:");

            string watching = Console.ReadLine();

            string person = Console.ReadLine().ToUpper();
            sw.WriteLine(ticketID + ", " + Summary + ", " + Status + ", " + 
            priority + ", " + Submitter + ", " + assigend + ", " + watching );


        }
        sw.Close();
    }

} while(choice == "1" || choice == "2");
