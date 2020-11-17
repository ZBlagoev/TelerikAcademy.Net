/*
Гошо много иска да се научи да разчита тайни съобщения. 
Съобщението се съдържда в буквите, но трябва да бъдат прочетени отзад напред.

Напишете програма, която да помага на Гошо с четенето на тайни съобщения.

Вход
Тайното съобщение се прочита от първия ред на входа.

Изход
Изведе резултата на единствен ред.

Ограничения
Дължината на съобщението няма да е повече от 10000

Съобщението ще се състои само от цифри и букви
*/

using System;
using System.Text;

namespace Secret_message
{
    class secret_message
    {
        static void Main(string[] args)
        {
            // input
            string message = Console.ReadLine();
            StringBuilder decoded = new StringBuilder("", 10000);

            // calculation
            for (int i = message.Length - 1; i >= 0; i--)
            {
                if (!(int.TryParse(message[i].ToString(), out int number)))
                {
                    decoded.AppendFormat($"{message[i]}");
                }
            }

            // output
            Console.WriteLine(decoded);


        }
    }
}
