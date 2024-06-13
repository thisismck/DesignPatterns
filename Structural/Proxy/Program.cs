// See https://aka.ms/new-console-template for more information
using Proxy;

Console.WriteLine("Hello, World!");
/*
 * Proxy Pattern
 * * 
 * * Definition: Provide a surrogate or placeholder for another object to control access to it.
 * * 
 * * The Proxy pattern is used to control access to an object. The proxy object acts as a surrogate or placeholder for the real object. 
 * * The proxy object controls access to the real object, allowing you to perform something either before or after the request gets through to the real object.
 * * 
 * * The Proxy pattern is used when you need to control access to an object. This can be useful in a number of situations, such as:
 * * - When you need to perform some action before or after the real object is accessed.
 * * - When you need to control access to the real object.
 * * - When you need to provide a level of security to the real object.
 * * - When you need to provide a level of abstraction to the real object.
 * * 
 * * The Proxy pattern is used in a number of different ways, such as:
 * * - Virtual Proxy: A virtual proxy is used to control access to an object that is expensive to create. The virtual proxy creates the real object only when it is needed.
 * * - Protection Proxy: A protection proxy is used to control access to an object based on the caller's permissions. The protection proxy checks the caller's permissions before allowing access to the real object.
 * * - Remote Proxy: A remote proxy is used to control access to an object that is located on a remote server. The remote proxy handles the communication between the client and the server.
 * * - Smart Proxy: A smart proxy is used to control access to an object based on the state of the object. The smart proxy performs some action before or after the request gets through to the real object.
 * * 
 * * The Proxy pattern is used in a number of different scenarios, such as:
 * * - Caching: A proxy can be used to cache the results of an expensive operation.
 * * - Logging: A proxy can be used to log the requests made to an object.
 * * - Security: A proxy can be used to control access to an object based on the caller's permissions.
 * * - Remote Access: A proxy can be used to control access to an object that is located on a remote server.
 * * - Lazy Loading: A proxy can be used to create the real object only when it is needed.
 * * 
 * * The Proxy pattern is used in a number of different programming languages, such as:
 * * - C#: The Proxy pattern is used in C
 */

MathProxy mathProxy = new MathProxy();
Console.WriteLine(mathProxy.Division(10, 2));
Console.WriteLine(mathProxy.Division(10, 0));

