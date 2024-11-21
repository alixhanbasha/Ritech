
using CommandLine;
using CommandLine.Text;

namespace Ritech.Utils
{

    public class Options
    {
        [Option('d', "useDriver", Required = true, HelpText = "What driver should automation use? android | ios")]
        public string InputFile { get; set; }

    }

}