namespace CSTOJS_BWA
{
	using System.ComponentModel.DataAnnotations;

	public class CSTOJSModel
	{
		[Required]
		public string CSString { get; set; } = string.Empty;

		public string JSString { get; set; } = string.Empty;

		public bool Display { get; set; } = true;


		public bool Debug { get; set; } = false;
	}
}
