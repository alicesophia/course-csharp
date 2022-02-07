using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Course.Entities.Enums;
using System.IO;

namespace Course {
    class Program {

        static void Main(string[] args) {

            //Exemplo sobre Dictionary e SortedDictionary
            //Declara o Dictionary com os 2 tipos (da chave e do valor)
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            //É possível fazer assim ao invés do .Add
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["phone"] = "99771133";            
            
            Console.WriteLine(cookies["email"]);
            
            cookies.Remove("email");
            
            Console.WriteLine("Phone number: " + cookies["phone"]);
            
            if (cookies.ContainsKey("email")) {
                Console.WriteLine("Email: " + cookies["email"]);
            } else {
                Console.WriteLine("There is not 'email' key");
            }
            
            Console.WriteLine("Size: " + cookies.Count);
            
            Console.WriteLine("ALL COOKIES:");

            //No lugar de KeyValuePair também pode ser usado o var
            foreach (KeyValuePair<string, string> item in cookies) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }


            //Exemplos de HashSet e SortedSet
            /*Console.WriteLine("HashSet: ");
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            
            Console.WriteLine(set.Contains("Computer"));

            foreach (string s in set) {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("SortedSet: ");

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            //União de conjuntos
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            //Intersecção de conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d);

            //Diferença de conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(e);*/

            //Exemplos de GetHasCode e Equals
            /*Client client1 = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client client2 = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(client1.Equals(client2));
            //O == compara a referência do ponteiro de memória do objeto, então com o mesmo email os clientes vão ser diferentes usando o ==
            Console.WriteLine(client1 == client2);
            Console.WriteLine(client1.GetHashCode());
            Console.WriteLine(client2.GetHashCode());

            string a = "Maria";
            string b = "José";
            
            //Para cada objeto é gerado um hash code diferente
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());*/

            //Trabalhando com arquivos

            //Path
            /*string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());*/

            //Directory, DirectoryInfo (operações com pastas)
            /*string path = @"c:\temp\myfolder";

            try {
                //Listar todas as pastas de um diretório
                //Ao invés do var é possível usar o IEnumerable<string>
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                //Listar todos os arquivos em um diretório (pasta e subpastas)
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                //Criar uma pasta
                Directory.CreateDirectory(path + @"\newfolder");

            } catch (IOException e) {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }*/

            //StreamWriter
            /*string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try {

                string[] lines = File.ReadAllLines(sourcePath);

                //ApendText irá concatenar o texto no final do arquivo
                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }


            } catch (IOException e) {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }*/

            //Using block
            /*string path = @"c:\temp\file1.txt";

            //Tudo dentro do bloco using será executado, após isso o recurso instanciado (ex: FileStream) será fechado
            //É possível usar um bloco using dentro de outro
            try {

                //Método simplificado instanciando 1 objeto
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

                //Instanciando 2 objetos
                //using (FileStream fs = new FileStream(path, FileMode.Open)) {
                //    using (StreamReader sr = new StreamReader(fs)) {
                //        while (!sr.EndOfStream) {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }
                //    }
                //}

            } catch (IOException e) {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
            /*

            //FileStream e StreamReader
            /*string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try {

                //sr = File.OpenText(); //Método mais simples, File.OpenText já instancia o FileStream e o StreamReader
                                        //automáticamente, desse modo não é necessário instanciar e fechar um FIleStream
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException e) {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            } finally {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }*/

            //File, FileInfo e IOException
            /*string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }

            } catch (IOException e) {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }*/

            //try-catch-finally
            /*try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            } catch (DivideByZeroException e) {
                Console.WriteLine($"Error! {e.Message}");
            }catch (FormatException e) {
                Console.WriteLine($"Format error! {e.Message}");
            } finally {
                Console.WriteLine("Finally example");
            }*/

            //Exemplos Enum
            /*Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Conversão de Enum para string
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Conversão de string para Enum
            Console.WriteLine(os);*/

            //DateTimeKind e Padrão ISO 8601
            /*DateTime d1 = DateTime.Parse("2021-12-15 12:02:52");
            DateTime d2 = DateTime.Parse("2021-12-15T12:02:52Z");

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine(d1);
            Console.WriteLine($"d1 Kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC {d1.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine(d2);
            Console.WriteLine($"d1 Kind: {d2.Kind}");
            Console.WriteLine($"d1 to Local {d2.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC {d2.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));*/

            /*DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine($"d1 Kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC {d1.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine(d2);
            Console.WriteLine($"d1 Kind: {d2.Kind}");
            Console.WriteLine($"d1 to Local {d2.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC {d2.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine(d2);
            Console.WriteLine($"d1 Kind: {d2.Kind}");
            Console.WriteLine($"d1 to Local {d2.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC {d2.ToUniversalTime()}");*/

            //Propriedades e operaçoes com TimeSpan
            /*TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            TimeSpan t4 = new TimeSpan(2, 3, 5 ,7, 11);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan ts1 = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts1.Add(ts2);
            TimeSpan dif = ts1.Subtract(ts2);
            TimeSpan mult = ts2.Multiply(2);
            TimeSpan div = ts2.Divide(2);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);*/

            //Propriedades e operações com DateTime
            /*DateTime d1 = new DateTime(2022, 01, 10, 10, 31, 52, 275);             

            Console.WriteLine(d1);
            Console.WriteLine($"(1) Date: {d1.Date}");
            Console.WriteLine($"(2) Day: {d1.Day}");
            Console.WriteLine($"(3) DayOfWeek: {d1.DayOfWeek}");
            Console.WriteLine($"(4) DayOfYear: {d1.DayOfYear}");
            Console.WriteLine($"(5) Hour: {d1.Hour}");
            Console.WriteLine($"(6) Kind: {d1.Kind}");
            Console.WriteLine($"(7) Millisecond: {d1.Millisecond}");
            Console.WriteLine($"(8) Minute: {d1.Minute}");
            Console.WriteLine($"(9) Month: {d1.Month}");
            Console.WriteLine($"(10) Second: {d1.Second}");
            Console.WriteLine($"(11) Ticks: {d1.Ticks}");
            Console.WriteLine($"(12) TimeOfDay: {d1.TimeOfDay}");
            Console.WriteLine($"(13) Year: {d1.Year}");
            Console.WriteLine();
            Console.WriteLine($"{d1.ToLongDateString()}, {d1.ToLongTimeString()}"); //Retorna a data em string
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine();
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss")); //formatar manualmente data
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff")); //formatar manualmente data (ss.fff - imprimir segundos e milisegundos)

            Console.WriteLine();
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.AddHours(2)); //Adicionar horas no datetime
            Console.WriteLine(now.AddMinutes(3)); //Adicionar minutos no datetime
            Console.WriteLine(now.AddDays(7)); //Adicionar dias no datetime
            TimeSpan t = now.Subtract(d1); //Diferença entre 2 datas (retorna um TimeSpan)
            Console.WriteLine(t);*/

            //Exemplo de timespan
            /*TimeSpan t1 = new TimeSpan(0, 1, 30); //construtor TimeSpan(hora, minuto, segundo)
            TimeSpan t2 = new TimeSpan(); //construtor vazio 00:00:00
            TimeSpan t3 = new TimeSpan(900000000L); //Construtor passando ticks
            TimeSpan t4 = new TimeSpan(10, 18, 00); //(hora, minuto, segundo)
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21); //(dia, hora, minuto, segundo)
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321); //(dia, hora, minuto, segundo, milisegundos)

            TimeSpan fromDays = TimeSpan.FromDays(1.5); //TimeSpan de 1 dia e meio
            TimeSpan fromHours = TimeSpan.FromHours(1.5); //TimeSpan de 1 hora e meia
            TimeSpan fromMinutes = TimeSpan.FromMinutes(1.5); //TimeSpan de 1 minuto e meio
            TimeSpan fromSeconds = TimeSpan.FromSeconds(1.5); //TimeSpan de 1 segundo e meio
            TimeSpan fromMiliseconds = TimeSpan.FromMilliseconds(1.5); //TimeSpan de 1 milisegundo e meio

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine();
            Console.WriteLine(fromDays);
            Console.WriteLine(fromHours);
            Console.WriteLine(fromMinutes);
            Console.WriteLine(fromSeconds);
            Console.WriteLine(fromMiliseconds);*/

            //Exemplo de datetime            
            /*DateTime d1 = new DateTime(2022, 01, 10); //construtor Datetime(ano, mes, dia)
            DateTime d2 = new DateTime(2022, 01, 10, 20, 45, 3); //construtor Datetime(ano, mes, dia, hora, minuto, segundo)
            DateTime d3 = new DateTime(2022, 01, 10, 20, 45, 3, 500); //construtor Datetime(ano, mes, dia, hora, minuto, segundo, nanosegundo)
            DateTime d4 = DateTime.Now; //data e hora do sistema
            DateTime d5 = DateTime.Today; //data do dia atual mas com hora 00:00:00
            DateTime d6 = DateTime.UtcNow; //horário atual GMT
            DateTime d7 = DateTime.Parse("2022-01-10 09:46:00"); //conversão de string para Datetime (formato normalmente usado em banco de dados)
            DateTime d8 = DateTime.Parse("10/01/2022 09:47:00"); //conversão no formato brasileiro
            DateTime d9 = DateTime.ParseExact("2022-01-10", "yyyy-MM-dd", CultureInfo.InvariantCulture); //determinar o formato da data
            DateTime d10 = DateTime.ParseExact("10/01/2022 09:58:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);*/

            //Funções interessantes para strings
            /*string original = "abcde FGHIJ ABC abc DEFG   ";

            Console.WriteLine($"-{original}-");
            Console.WriteLine();
            string s1 = original.ToUpper();
            Console.WriteLine($"ToUpper: -{s1}-");

            Console.WriteLine();
            string s2 = original.ToLower();
            Console.WriteLine($"ToLower: -{s2}-");

            Console.WriteLine();
            string s3 = original.Trim();
            Console.WriteLine($"Trim: -{s3}-");

            int n1 = original.IndexOf("bc");
            Console.WriteLine($"IndexOf('bc'): {n1}");

            int n2 = original.LastIndexOf("bc");
            Console.WriteLine($"LastIndexOf('bc'): {n2}");

            string s4 = original.Substring(3);
            Console.WriteLine($"Substring(3): -{s4}-");

            string s5 = original.Substring(3, 5);
            Console.WriteLine($"Substring(3, 5): -{s5}-");

            string s6 = original.Replace("a", "x");
            Console.WriteLine($"Replace(a, x): -{s6}-");

            string s7 = original.Replace("abc", "xy");
            Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");

            bool b1 = string.IsNullOrEmpty(original);
            Console.WriteLine($"IsNullOrEmpty: {b1}");

            bool b2 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");*/

            //Expressão condicional ternária
            /*double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;            

            Console.WriteLine(desconto);*/

            //Exemplo case
            /*int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda-feira";
                    break;
                case 3:
                    day = "Terça-feira";
                    break;
                case 4:
                    day = "Quarta-feira";
                    break;
                case 5:
                    day = "Quinta-feira";
                    break;
                case 6:
                    day = "Sexta-feira";
                    break;
                case 7:
                    day = "Sábado";
                    break;
                default:
                    day = "Invalid value!";
                    break;
            }

            Console.WriteLine($"Day: {day}");*/

            //Exemplo var
            /*var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine($"{x} {y} {z}");*/

            //Exercicio fixação matrizes
            /*Console.WriteLine("Informe o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++) {
                string[] valoresLinha = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    matriz[i, j] = int.Parse(valoresLinha[j]);
                }                
            }

            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (matriz[i, j] == numero) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < colunas - 1) {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < linhas - 1) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }*/

            //Exercicio matrizes
            /*Console.WriteLine("Informe um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            int negatives = 0;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] < 0) {
                        negatives += 1;
                    }
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write($"{matriz[i, i]} ");         
            }

            Console.WriteLine();
            Console.WriteLine($"Negative numbers: {negatives}");*/

            //Declarar matriz e algumas propriedades
            /*double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length);

            Console.WriteLine(matriz.Rank);

            Console.WriteLine(matriz.GetLength(0));

            Console.WriteLine(matriz.GetLength(1));*/

            //Exercício Listas
            /*Console.WriteLine("How many employees will be registered?");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= numeroFuncionarios; i++) {
                
                Console.WriteLine($"Employee #{i}");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee ID that will have salary increase: ");
            int idAumentoSalario = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == idAumentoSalario);
            if (func != null) {
                Console.WriteLine("Enter the percentage: ");
                func.increseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("This ID does not exists!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Funcionario obj in list) {
                Console.WriteLine(obj);
            }*/

            /*//Listas
            List<string> lista = new List<string>();

            //Adicionar elementos na lista
            lista.Add("Alice");
            lista.Add("Sophia");
            lista.Add("Koch");
            lista.Add("Ana");
            lista.Insert(2, "Eduarda");

            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //Tamanho de elementos na lista
            Console.WriteLine("List count: " + lista.Count);
            
            //Encontrar primeiro elemento da lista que satisfaça um predicado
            //Expressão lambda dentro do Find: lista.Find(string x => caractere posição 0 == 'A')
            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //Encontrar último elemento da lista que satisfaça um predicado
            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //Posição do primeiro elemento que começa com a letra A
            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //Posição do último elemento que começa com a letra A
            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------");
            foreach (string obj in lista2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------");
            lista.Remove("Ana");            
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //Remove todos 
            Console.WriteLine("--------------------");
            lista.RemoveAll(x => x[0] == 'E');
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //Remove um elemento em uma posição
            Console.WriteLine("---------------------");
            lista.RemoveAt(2);
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //Remover um range (posição, count para remover após posição)
            Console.WriteLine("---------------------");
            lista.RemoveRange(0, 1);
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //Instanciando uma lista de string vazia
            /*List<string> lista = new List<string>();

            //Instanciando uma lista de string e populando com valores
            List<string> list2 = new List<String> { "Alice", "Sophia" };*/

            //Exemplo foreach
            /*string[] vetor = new string[] { "Alice", "Sophia", "Eduarda"} ;

            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("--------------------------------");

            foreach (string obj in vetor) {
                Console.WriteLine(obj);
            }*/

            //Exercícios ref e out
            /*int a = 10;
            int triplo;
            Calculadora.Triple(a, out triplo);
            Console.WriteLine(triplo);*/

            //Exercicio paramêtro params
            //Console.WriteLine(Calculadora.Soma(1, 2, 3));

            //Exercício Vetores
            /*Estudante[] estudante = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados?");s
            int numeroQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroQuartos; i++) {                
                Console.WriteLine("Quarto #" + i);

                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudante[quarto] = new Estudante(nome, email, quarto);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < estudante.Length; i++) {
                if (estudante[i] != null) {
                    Console.WriteLine(estudante[i]);
                }
            }*/

        }

        //IEnumerable é uma interface implementada em todos as coleções do pacote System.Collections.Generic;
        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
