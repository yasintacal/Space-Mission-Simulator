using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eski_nesil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region game name
            Console.OutputEncoding = System.Text.Encoding.UTF8; // çıktı kodlamasını UTF-8 yapar. çünkü ASCII de bazı özel karakterler yazdırılamaz
                                                                //aşşağıdaki koddaki @ işareti tırnak içindeki ters eğik çizgileri işlevsiz kılar.
            string banner = @"
               _____ ____  ___   ______ ______                                       /\
              / ___// __ \/   | / ____// ____/                                      /..\
              \__ \/ /_/ / /| |/ /    / __/                                        / \/ \
             ___/ / ____/ ___ / /___ / /___                                       /======\
            /____/_/   /_/  |_\____//_____/                                      // |==| \\
                                                                                //  |  |  \\
               __  __ _____ _____ _____  _____ ____  _   __                    //   |==|   \\
              |  \/  |_   _/ ____/ ____||_   _/ __ \| \ | |                   ||    |  |    ||
              | \  / | | || (___ | (___   | || |  | |  \| |                   ||    |==|    ||
              | |\/| | | | \___ \ \___ \  | || |  | | . ` |                   ||   /====\   ||
              | |  | |_| |_____) |____) |_| || |__| | |\  |                    \\  \====/  //
              |_|  |_|_____|_____/_____/|_____\____/|_| \_|                     \\  /  \  //
                                                                                 \\/====\//
               _____ _____ __  __ _    _ _            _______ ____  _____         /======\
              / ____|_   _|  \/  | |  | | |        /\|__   __/ __ \|  __ \       // |||| \\
             | (___   | | | \  / | |  | | |       /  \  | | | |  | | |__) |     //  ||||  \\
              \___ \  | | | |\/| | |  | | |      / /\ \ | | | |  | |  _  /         (::::)
              ____) |_| |_| |  | | |__| | |____ / ____ \| | | |__| | | \ \        ((::::))
             |_____/|_____|_|  |_|\____/|______/_/    \_\_|  \____/|_|  \_\      ((  ::  ))
                                                                                ((   ::   ))
                                                                                (     :    )
                                                                                '          '
            ";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(banner);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('=', 95));
            Console.ResetColor();
            #endregion
        }
    }
}
