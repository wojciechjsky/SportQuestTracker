using System.Collections.Generic;
using SportQuestTracker.Contracts;

namespace SportQuestTracker.Models
{
    public class GadgetRepository: IGadgetRepository
    {
        public IEnumerable<Gadget> AllGadgets { get; }
        public Gadget GetGadgetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}