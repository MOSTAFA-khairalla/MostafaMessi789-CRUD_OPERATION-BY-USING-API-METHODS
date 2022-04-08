using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.DAl.Database;
using WebApplication31.Models;

namespace WebApplication31.BI.Repository
{
    public class SigntureRepos
    {


        DbContainer db = new DbContainer();
        public class SigntureRepo : ISigntureRepo
        {
            public void Create(SigntureVm vm)
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<SigntureVm> Get()
            {
                throw new NotImplementedException();
            }

            public SigntureVm GetById(int id)
            {
                throw new NotImplementedException();
            }

            public void update(SigntureVm vm)
            {
                throw new NotImplementedException();
            }
        }

        public interface ISigntureRepo
        {

            IEnumerable<SigntureVm> Get();
            SigntureVm GetById(int id);
            void Delete(int id);
            void update(SigntureVm vm);
            void Create(SigntureVm vm);


        }


    }
}
