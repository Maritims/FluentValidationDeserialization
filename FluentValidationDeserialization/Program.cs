using FluentValidation.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var validationFailure = new ValidationFailure("", "this is an error");
            var serialized = JsonConvert.SerializeObject(validationFailure);
            var deserialized = JsonConvert.DeserializeObject<ValidationFailure>(serialized);
        }
    }
}
