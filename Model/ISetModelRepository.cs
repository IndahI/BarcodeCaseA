using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.Model
{
    public interface ISetModelRepository
    {
        List<string> GetData();
        string GetID(string selectedModel);
        string GetModelCode(string selectedModel);
    }
}
