namespace NaturalOne.Models
{
    public class TraitEditorTemplate
    {
        public IList<TraitEditor> Editors { get; set; } = new List<TraitEditor>();
    }

    public class TraitEditor
    {
        public TraitEditor(string id, string name)
        {
            Id = id;
            Name = name;
            SelectItems = new List<SelectListItem>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public IList<SelectListItem> SelectItems { get; set; }
    }
}