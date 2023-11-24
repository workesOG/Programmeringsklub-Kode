using System.Data.Common;

namespace Code;

class Program
{
    static readonly Dictionary<string, Action> scripts = new();
    static void Main(string[] args)
    {
        GetScripts();
        scripts["Functions.js"].Invoke(); //Put the script you want to run in this field. Use the full name (plus extension, for example 'Variables.js').
    }

    static void GetScripts()
    {
        scripts.Add("Variables.js", () => {Variables variables = new(); variables.Main();});
        scripts.Add("Functions.js", () => {Functions functions = new(); functions.Main();});
    }
}