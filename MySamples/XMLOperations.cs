using System;
using System.Collections.Generic;

namespace Learning.MySamples
{
    public class XMLOperations
    {
        public static void XMLOperation(string[] args)
        {
            var operations = new Dictionary<string, Operation>();

            while (true)
            {
                string attributeName;
                string attributeValue;

                Console.WriteLine("Operations:");
                Console.WriteLine("1. Add \n 2. Update \n 3. Delete \n 4. Perform Operations");
                Console.Write("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\n Enter attribute name: ");
                        attributeName = Console.ReadLine();

                        Console.Write("\n Enter attribute value: ");
                        attributeValue = Console.ReadLine();

                        var addOperation = new Operation(attributeName, OperationType.Add, attributeValue);
                        operations.Add(attributeName, addOperation);

                        break;

                    case 2:
                        Console.Write("\n Enter attribute name: ");
                        attributeName = Console.ReadLine();

                        Console.Write("\n Enter attribute value: ");
                        attributeValue = Console.ReadLine();

                        var updateOperation = new Operation(attributeName, OperationType.Update, attributeValue);
                        operations.Add(attributeName, updateOperation);

                        break;
                    case 3:
                        Console.Write("\n Enter attribute name: ");
                        attributeName = Console.ReadLine();

                        var deleteOperation = new Operation(attributeName, OperationType.Delete);
                        operations.Add(attributeName, deleteOperation);

                        break;
                    case 4:
                        var fileModifier = new XMLFileModifier(operations);

                        fileModifier.PerformOperations();


                        // stop while loop after this
                        break;
                }
            }
        }
    }

    public class XMLFileModifier
    {
        public Dictionary<string, Operation> Operations;

        public XMLFileModifier(Dictionary<string, Operation> operations)
        {
            this.Operations = operations;
        }

        public void PerformOperations()
        {
            if (this.Operations.ContainsKey(" ")) //// O(1) time, can compare all the attributes using this
            {

            }

            //// Parse your xml file using xml parser and perform all the above operations here
        }
    }

    public class Operation
    {
        public Operation(string attributeName, OperationType type, string value = "")
        {
            this.AttributeName = attributeName;
            this.Type = type;
            this.Value = value;
        }

        public string AttributeName;

        public OperationType Type;

        public string Value;
    }

    public enum OperationType
    {
        Add = 0,
        Update = 1,
        Delete = 2,
    }
}