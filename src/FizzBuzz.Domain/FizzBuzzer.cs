using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Domain
{
    public static class FizzBuzzer
    {
        public static string Run()
        {
            IEnumerable<string> fizzbuzzValues = Enumerable.Range(1, 20).Select(Converter);

            return string.Join(' ', fizzbuzzValues);
        }

        private static string Converter(int arg)
        {
            bool lucky = arg.ToString().Contains("3");
            bool fizz = arg % 3 == 0;
            bool buzz = arg % 5 == 0;

            if (lucky) return "lucky";
            if (fizz && buzz) return "fizzbuzz";
            if (fizz) return "fizz";
            if (buzz) return "buzz";

            return arg.ToString();
        }

    }
}
