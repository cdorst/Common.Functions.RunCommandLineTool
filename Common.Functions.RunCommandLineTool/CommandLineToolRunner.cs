using static Common.Functions.JoinCommandLineArguments.CommandLineArgumentsJoiner;
using static Common.Functions.RunCommandLine.CommandLineRunner;

namespace Common.Functions.RunCommandLineTool
{
    public static class CommandLineToolRunner
    {
        public static void Prompt(string directory, string tool, string command, params string[] arguments)
            => Run(directory,
                command: tool,
                arguments: Join(command, arguments));
    }
}
