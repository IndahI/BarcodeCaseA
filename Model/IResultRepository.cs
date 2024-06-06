using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.Model
{
    public interface IResultRepository
    {
        IEnumerable<CaseModel> GetAll();
        IEnumerable<CaseModel> GetFilter(DateTime selectDate);
        (bool success, string errorMessage) addData(dynamic model);
    }
}
