using System.Collections.Generic;

namespace LINQTasks
{
    public delegate int TransformationFunction (int number);
    
    public static class TransformClass
    {
        public static IEnumerable<int> Transform (this IEnumerable<int> IEnumrableParameter, TransformationFunction FunctionParameter )
        {

            foreach (var output in IEnumrableParameter)
                yield return FunctionParameter(output);


        }

    }
    
}