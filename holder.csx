public class ResourceBase
{
	public ResourceBase()
	{
		resourceType = base.GetType().Name;
	}

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public IdReference parent { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public Dictionary<string, Dictionary<string, string>> ConfigValues { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string resourceVersion { get; set; } = "1.0";

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string name { get; set; } = "";

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public List<string> tags { get; set; } = new List<string>();

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string resourceType { get; set; }
}