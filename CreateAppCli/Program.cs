using System;
using CommandLine;

namespace create_app
{
    class Program
    {
        class Options
        {
            [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
            public bool Verbose { get; set; }
        }
    
        [Verb("save", HelpText = "Save a template based on a project")]
        class SaveOptions {
            [Option('t', "template", Required = false, HelpText = "Template location")]
            public string TemplateLocation { get; set; }
        }

        static int Main(string[] args)
        {
            return Parser.Default.ParseArguments<Options, SaveOptions>(args)
                .MapResult((Options opts) => 0, (SaveOptions opts) => 0, errs => 1);
        }
    }
}