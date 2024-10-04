
using System;
using System.Collections.Generic;
using TP2.BE;
using TP2.BLL.interfaces;
using TP2.DAL;

namespace TP2.BLL
{
    public class CRUDtrabajador : Icrud<Trabajador>
    {

        private TrabajadorRepository _repository;

        public CRUDtrabajador()
        {
            _repository = new TrabajadorRepository();
        }
        public void Delete(Trabajador entity)
        {
            throw new NotImplementedException();
        }

        public Trabajador FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Trabajador> GetAll()
        {
            List<Trabajador> trabajadores = _repository.ObtenerTrabajadores();
            foreach (var item in trabajadores)
            {
                item.Sueldo = CalcularSueldo.Calcular(item);
            }
            return trabajadores;
        }

        public void Insert(Trabajador entity)
        {
            _repository.AgregarTrabajador(entity);
        }

        public void Update(Trabajador entity)
        {
            int  id = entity.Id;
            //_repository.ObtenerTrabajadores().FindIndex(x => x.Id == entity.Id)
            _repository.EditarTrabajador(id, entity);
        }
    }
}
