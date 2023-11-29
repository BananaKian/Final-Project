using Final_Project.Data;

namespace Final_Project.Services
{
    public class SpellsService : ISpellsService
    {
        public List<Spell> Spellbook { get; set; } = new List<Spell>();
    }
}