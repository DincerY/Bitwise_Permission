using System.Net;

namespace Bitwise_Permission
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var permission = FilePermissions.Read | FilePermissions.Write | FilePermissions.Execute;

            //Read permission delete
            permission = permission & ~FilePermissions.Read;


            var hasRead = (permission & FilePermissions.Read) == FilePermissions.Read;

            var hasWrite = (permission & FilePermissions.Write) == FilePermissions.Write;

            var hasExecute = (permission & FilePermissions.Execute) == FilePermissions.Execute;

            var hasAdmin = (permission & FilePermissions.Admin) == FilePermissions.Admin; 

        }
    }

    enum FilePermissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        ReadAndWrite = Read | Write,
        Execute = 4,
        Admin = 8,
    }
}