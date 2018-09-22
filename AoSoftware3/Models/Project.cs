namespace AoSoftware.Models
{
	public enum ProjectType
	{
		/// <summary>
		/// Library or other project of mine that is open-source
		/// </summary>
		OpenSource,
		/// <summary>
		/// Something I sell
		/// </summary>
		Application,
		/// <summary>
		/// Something I worked on
		/// </summary>
		PortfolioEntry,
		/// <summary>
		/// Something I can do
		/// </summary>
		Service
	}

	public class Project 
	{
		/// <summary>
		/// Unique name of project, doubles as view name in Projects folder
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// App or library name
		/// </summary>
		public string Name { get; set; }

		public ProjectType Type { get; set; }

		public string Description { get; set; }

		/// <summary>
		/// Image on AOSoftware.net that depicts project
		/// </summary>
		public string LocalImage { get; set; }

		/// <summary>
		/// Name of Nuget package(s), if applicable
		/// </summary>
		public string[] NugetPackages { get; set; }

		/// <summary>
		/// Public URL for project
		/// </summary>
		public string PublicUrl { get; set; }

		/// <summary>
		/// Source of price
		/// </summary>
		public string PriceInfoUrl { get; set; }

		/// <summary>
		/// Starting price, as applicable
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Project is visible on home page
		/// </summary>
		public bool IsActive { get; set; } = true;
	}
}