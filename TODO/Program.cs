// See https://aka.ms/new-console-template for more information

using TODO;


List<cardDetail> cartDetail = new();
List<string> TakimÜyesiDetail = new();

cardDetail detail = new();
detail.icerik = "Settings";
detail.baslik = "addCampaign";
cartDetail.Add(detail);
cardDetail detail2 = new cardDetail();
detail2.icerik = "Ayarlar";
detail2.baslik = "Kampanya Ekleme";
cartDetail.Add(detail2);
cardDetail detail3 = new cardDetail();
detail2.icerik = "Person";
detail2.baslik = "addPerson";
cartDetail.Add(detail3);

board board = new();



List<object> todo = new();

todo.Add(detail);
todo.Add(detail2);
todo.Add(detail3);



//List<int> Board_TODO = new List<int>();
//List<int> IN_PROGRESS = new List<int>();
//List<int> DONE = new List<int>();

Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) " +
    "\r\n *******************************************\r\n" +
    " (1) Board Listelemek\r\n " + "(2) Board'a Kart Eklemek\r\n "
    + "(3) Board'dan Kart Silmek\r\n " + "(4) Kart Taşımak");
int deger = Convert.ToInt32(Console.ReadLine());
if (deger == 1)
{
    Console.WriteLine(" TODO Line\r\n" + "************************");
    foreach (var item in cartDetail)
    {
        Console.WriteLine(" Başlık: {0}\r\n İçerik: {1}\r\n Atanan Kişi: {2}\r\n Büyüklük: {3} " +
            "",item.baslik,item.icerik,item.atanan_kisi,item.büyüklük +"\r\n" + "***********************");
    }

}
