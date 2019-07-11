using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
/*
* TCP 클라이언트 - 파일데이터를 서버에 송신
*/
namespace TCP클라이언트
{
    class Program
    {
        static void Main(string[] args)
        {
            //서버연결
            TcpClient client = new TcpClient("127.0.0.1", 10000);
            //NetworkStream stream = client.GetStream();
            using (var stream = client.GetStream())
            {


                //업로드할 파일을 열기

                //파일을 읽은 만큼 서버에 송신

                //파일 닫기
            }

            //서버 연결 끊기
            //stream.Close();
            client.Close();
        }
    }
}
