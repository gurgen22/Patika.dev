using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    public class board
    {
        public  List<TODO> todo = new();
        public  List<IN_PROGRESS> inProgress = new();
        public  List<DONE> done = new();
    }
    public class TODO
    {
        public List<object> listTodo = new();
    }
    public class IN_PROGRESS
    {
        public List<object> listInProgress = new();
    }
    public class DONE
    {
        public List<object> ListDone = new();
    }


    public class Card
    {
        public List<cardDetail> cartDetail = new();
    }
    
    public class cardDetail
    {
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string atanan_kisi { get; set; } = "Merve Can";
        public string büyüklük { get; set; } = "XS";
    }

}
