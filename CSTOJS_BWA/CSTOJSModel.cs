namespace CSTOJS_BWA
{
	using System.Collections.Generic;
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Text;

	public class CSTOJSModel
	{
		[Required]
		public string CSString { get; set; } = string.Empty;

		public string JSString { get; set; } = string.Empty;

		public bool Display { get; set; } = true;


		public bool Debug { get; set; } = false;
		public bool DisableConsoleOutput { get; set; } = false;
		public bool UseVarOverLet { get; set; } = false;
		public bool KeepBraceOnTheSameLine { get; set; } = false;
		public bool NormalizeWhitespace { get; set; } = false;
		public string CustomCSNamesToJS { get; set; } = string.Empty;
		public string AddSBAtTheTop { get; set; } = string.Empty;
		public string AddSBAtTheBottom { get; set; } = string.Empty;
	}
}
