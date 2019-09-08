using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.BaseRepository
{
    public class BaseRepository<T> where T:BaseEntity //Burası düzeltilecek ancak önce ınterface'de eksik var mı bakılacak.
    {
    }
}
