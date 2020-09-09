using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTracker.Models
{
    public interface IGadgetRepository
    {
        IEnumerable<Gadget> AllGadgets { get; }
        Gadget GetGadgetById(int id);
    }
}
