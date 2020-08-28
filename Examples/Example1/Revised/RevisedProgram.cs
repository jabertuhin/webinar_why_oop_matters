using Example1.Revised;
using System;

namespace Example1
{
    class RevisedProgram
    {
        static void Main2(string[] args)
        {
            var inputProcessor = new InputProcessor();
            var outputProcessor = new OutputProcessor(" ");
            var fibonacciSeries = new FibonacciSeries(0, 1);

            while(true)
            {
                var position = inputProcessor.ReadInput() - 2;

                if(position.HasValue)
                {
                    outputProcessor.PrintNumber(fibonacciSeries.FirstNumber);
                    outputProcessor.PrintNumber(fibonacciSeries.SecondNumber);

                    for(var i = 0; i < position; i++)
                    {
                        if (i < position - 1)
                            outputProcessor.PrintNumber(fibonacciSeries.Next());
                        else
                            outputProcessor.PrintLastNumber(fibonacciSeries.Next());
                    }
                }
            }
        }
    }
}
