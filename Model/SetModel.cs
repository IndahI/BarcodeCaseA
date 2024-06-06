using BarcodeCaseA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.Model
{
    public class SetModel
    {
        private SetModelRepository _repository;

        public SetModel()
        {
            _repository = new SetModelRepository();
        }

        public List<string> GetSetModel()
        {
            return _repository.GetData();
        }

        public string GetModelId(string selectedModel)
        {
            return _repository.GetID(selectedModel);
        }

        public string GetModelCode(string selectedModel)
        {
            return _repository.GetModelCode(selectedModel);
        }

    }
}
