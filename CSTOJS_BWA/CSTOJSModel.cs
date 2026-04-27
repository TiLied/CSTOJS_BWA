using System.ComponentModel.DataAnnotations;

namespace CSTOJS_BWA;

public class CSTOJSModel
{
	[Required]
	public string CSString { get; set; } = string.Empty;

	public string JSString { get; set; } = string.Empty;

	public bool Display { get; set; } = true;


	public bool Debug { get; set; } = false;
	public bool DisableConsoleOutput { get; set; } = false;
	public bool DisableDiagnostics { get; set; } = false;
	public bool UseVarOverLet { get; set; } = false;
	public bool KeepBraceOnTheSameLine { get; set; } = false;
	public bool NormalizeWhitespace { get; set; } = false;
	public bool MakePropertiesEnumerable { get; set; } = false;

	public int EnableModules { get; set; } = 1;

	public string CustomCSNamesToJS { get; set; } = string.Empty;
	public string AddSBAtTheTop { get; set; } = string.Empty;
	public string AddSBAtTheBottom { get; set; } = string.Empty;
}

