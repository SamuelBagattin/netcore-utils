using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiErrorHandlingMiddleware.ModelsGenerator
{
    internal static class Program
    {
        private static async Task Main()
        {
            var dir = Directory.GetCurrentDirectory();
            var dirFiles = Directory.GetFiles(dir);
            while (dirFiles.All(e =>
                e.Split(Path.DirectorySeparatorChar).Last() != "ApiErrorHandlingMiddleware.ExceptionsGenerator.csproj"))
            {
                dir = Directory.GetParent(dir).FullName;
                dirFiles = Directory.GetFiles(dir);
            }

            var middlewareDir = Directory.GetParent(dir).GetDirectories()
                .FirstOrDefault(e => e.Name == "ApiErrorHandlingMiddleware");

            Type enumType = typeof(HttpStatusCode);
            Type enumUnderlyingType = Enum.GetUnderlyingType(enumType);
            Array enumValues = Enum.GetValues(enumType);

            foreach (var enumName in typeof(HttpStatusCode).GetEnumNames().Select((value, i) => new {i, value}))
            {
                // Retrieve the value of the ith enum item.
                object value = enumValues.GetValue(enumName.i);

                // Convert the value to its underlying type (int, byte, long, ...)
                var underlyingValue = Convert.ChangeType(value, enumUnderlyingType);

                if (underlyingValue != null && int.Parse(underlyingValue.ToString() ?? throw new InvalidOperationException()) < 400) continue;

                if (middlewareDir == null) return;

                await using var outputFile =
                    new StreamWriter(Path.Combine(middlewareDir.FullName, "Exceptions", $"{enumName.value}Exception.cs"));
                await outputFile.WriteAsync($@"
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{{
    /// <summary>
    /// {enumName.value} exception
    /// <see cref=""System.Net.HttpStatusCode.{enumName.value}""/>
    /// </summary>
    public class {enumName.value}Exception : BaseException
    {{

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.{enumName.value};

        /// <summary>
        /// Initializes a new instance of <see cref=""{enumName.value}Exception""/>
        /// </summary>
        public {enumName.value}Exception() {{ }}

        /// <summary>
        /// Initializes a new instance of <see cref=""{enumName.value}Exception""/>
        /// </summary>
        /// <param name=""message"">Error message</param>
        public {enumName.value}Exception(string message) : base(message){{ }}
    }}
}}
");
            }
        }
    }
}