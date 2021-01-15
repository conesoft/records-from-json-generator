using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace Records_From_Json_Generator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            context.AddSource("first test.cs", "using System;\nnamespace Demo {\n\tpublic class Test\n\t{\n\t\tpublic static string Hi => \"Hello, World!!\";\n\t}\n}");
        }
    }
}
