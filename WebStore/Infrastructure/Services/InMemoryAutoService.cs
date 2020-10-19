using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interface;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Services
{
    public class InMemoryAutoService : IAutoService
    {

        private readonly List<AutoViewModel> _auto = new List<AutoViewModel>
        {


            new AutoViewModel
            {
                Id = 1,
                Regnomer = "b123tn",
                Autoname = "Shkoda Octavia",
                Crash = false,
                Age = 5,
                Numbercrash = 0
            },

            new AutoViewModel
            {
                Id = 2,
                Regnomer = "c674te",
                Autoname = "Hyundai Tucson",
                Crash = true,
                Age = 4,
                Numbercrash = 3
            }
        };

        public void AddNew(AutoViewModel model)
        {
            model.Id = _auto.Max(e => e.Id);
            _auto.Add(model);
        }

        public void Commit()
        {
            //пока не исползуется 
        }

        public void Delete(int id)
        {
            var auto = GetById(id);
            if (auto is null)
                return;

            _auto.Remove(auto);
        }

        public IEnumerable<AutoViewModel> GetAll()
        {
            return _auto;
        }

        public AutoViewModel GetById(int id)
        {
            return _auto.FirstOrDefault(e => e.Id.Equals(id));
        }
    }
}
