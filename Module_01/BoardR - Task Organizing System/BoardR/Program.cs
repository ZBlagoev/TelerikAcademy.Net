using System;

namespace BoardR
{
    class Program
    {
        static void Main(string[] args)
        {
            // make some board items
            var item1 = new BoardItem("Refactor this mess", DateTime.Now.AddDays(2));
            var item2 = new BoardItem("Cook dinner", DateTime.Now.AddHours(3));
            var item3 = new BoardItem("Provide feedback", DateTime.Now.AddDays(1));

            //var item4 = new BoardItem("aaa", DateTime.Now.AddDays(1));
            //var item4 = new BoardItem("read OOP additional resources", DateTime.Now.AddDays(-1));
            //var item4 = new BoardItem("aaaa", DateTime.Now);

            // test methods
            item1.PrintDueDate();
            item1.PrintStatus();
            item1.PrintTitle();

            Console.WriteLine();

            item1.PrintID();
            item2.PrintID();
            item3.PrintID();

            Console.WriteLine();

            item1.AdvanceStatus();
            item1.PrintStatus();
            item1.AdvanceStatus();
            item1.PrintStatus();
            item1.AdvanceStatus();
            item1.PrintStatus();
            item1.AdvanceStatus();
            item1.PrintStatus();
            item1.AdvanceStatus();
            item1.PrintStatus();
            item1.RevertStatus();
            item1.PrintStatus();

            Console.WriteLine();

            // add items to board
            Board.items.Add(item1);
            Board.items.Add(item2);
            Board.items.Add(item3);

            // test methods
            foreach (var boardItem in Board.items)
            {
                boardItem.AdvanceStatus();
            }

            foreach (var boardItem in Board.items)
            {
                Console.WriteLine(boardItem.ViewInfo());
            }

        }
    }
}
