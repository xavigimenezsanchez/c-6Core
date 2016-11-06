using System.Diagnostics;
using static System.Console;

namespace Ch05_Tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Debug says Hello C#!");
            Trace.WriteLine("Trace says Hello C#!");
#if KERMIT
            Trace.WriteLine("KERMIT is on!");
#endif
#if KERMIT && FOZZIE
            Trace.WriteLine("KERMIT and FOZZIE are on!");
#endif
            var ts = new TraceSwitch("PacktSwitch", "");
            Trace.WriteLine(ts.TraceError, "TraceError");
            Trace.WriteLine(ts.TraceWarning, "TraceWarning");
            Trace.WriteLine(ts.TraceInfo, "TraceInfo");
            Trace.WriteLine(ts.TraceVerbose, "TraceVerbose");
            Trace.Close(); // release any file or database listeners
            WriteLine("Press ENTER to close.");
            ReadLine();
        }
    }
}    