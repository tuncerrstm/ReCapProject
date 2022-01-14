using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2 || car.DailyPrice <= 0)
            {
                return new ErrorResult(Messages.CarAddingFailed);
            }

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarDetailDto> GetCarDetails(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetDetailsOfCars()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
