using AR.LinesManagementSystem.Context;
using AutoMapper;
using System;

namespace AR.LinesManagementSystem.Repositories
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private ArDBContext context;
        private readonly IMapper _mapper;
        public UnitOfWork(ArDBContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }


        private ConnectivityCategoryRepository _connectivityCategoryRepository;
        public ConnectivityCategoryRepository connectivityCategoryRepository
        {
            get
            {
                if (_connectivityCategoryRepository == null)
                {
                    _connectivityCategoryRepository = new ConnectivityCategoryRepository(context, _mapper);
                }
                return _connectivityCategoryRepository;
            }
        }



        private ConnectivityProviderTypeRepository _connectivityProviderTypeRepository;
        public ConnectivityProviderTypeRepository connectivityProviderTypeRepository
        {
            get
            {
                if (_connectivityProviderTypeRepository == null)
                {
                    _connectivityProviderTypeRepository = new ConnectivityProviderTypeRepository(context, _mapper);
                }
                return _connectivityProviderTypeRepository;
            }
        }



        private ReasonRepository _reasonRepository;
        public ReasonRepository reasonRepository
        {
            get
            {
                if (_reasonRepository == null)
                {
                    _reasonRepository = new ReasonRepository(context, _mapper);
                }
                return _reasonRepository;
            }
        }



        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //if (!this.disposed)
            //{
            //    if (disposing)
            //    {
            //        this.Dispose();
            //    }
            //}
            //this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            //GC.SuppressFinalize(this);
        }


    }
}