// See https://aka.ms/new-console-template for more information
using Decorator;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

//Stream fstream = new FileStream("data.txt", FileMode.Create);
//Stream mstream = new MemoryStream();
//Stream nstrean = new NetworkStream(new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp));
// Decorate the stream

//GZipStream stream = new GZipStream(fstream, CompressionLevel.Optimal);
//CryptoStream cstream = new CryptoStream(stream, new AesManaged().CreateEncryptor(), CryptoStreamMode.Write);


/*
 * Problem: Hali hazırda var olan bir nesneye yeni özellikler eklemek istiyoruz.
 *          Bunun için nesneyi değiştirmek istemiyoruz.
 *          
 *  Çözüm: Decorator Pattern
 */

IMail mail = new Mail();
mail.Send();

Console.WriteLine();

IMail mailWithAttachment = new MailWithAttachment(mail);
mailWithAttachment.Send();

Console.WriteLine();

IMail mailWithSignature = new MailWithSignature(mail);
mailWithSignature.Send();

Console.WriteLine();

IMail mailWithAttachmentAndSignature = new MailWithSignature(new MailWithAttachment(mail));
mailWithAttachmentAndSignature.Send();