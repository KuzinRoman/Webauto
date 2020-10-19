using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Interface
{
    public interface IAutoService
    {
        /// Получение списка сотрудников

        IEnumerable<AutoViewModel> GetAll();

        /// <summary>
        /// Получение сотрудника по id
        /// <param name="id">Id</param>
        /// <returns></returns>
        AutoViewModel GetById(int id);

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void Commit();

        /// <summary>
        /// Добавить нового
        /// </summary>
        /// <param name="model"></param>
        void AddNew(AutoViewModel model);

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
