using System.Collections.Generic;
using SportQuestTracker.Models;

namespace SportQuestTracker.Contracts
{
    public interface IGadgetRepository
    {
        IEnumerable<Gadget> AllGadgets { get; }
        Gadget GetGadgetById(int id);
    }
}
