using System;
using System.Threading;

namespace Uncharted_Drake_s_Fortune
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы говорите по русский? | Do you speak English?");
            string speak = Console.ReadLine();
            if (speak == "Русский")
            {
                Console.WriteLine("Добро пожаловать в Uncharted: Drake’s Fortune, правда ввиде квест игры.");
                Console.WriteLine("Ну, начнём?");
                string start = Console.ReadLine();
                if ((start == "Да") || (start == "да") || (start == "Yes") || (start == "yes") || (start == "YES") || (start == "ДА"))
                {
                    Console.WriteLine("Отлично!, мы начинаем!");
                    Thread.Sleep(1000);
                    Console.WriteLine("И так, история Нейта начинается");
                    Thread.Sleep(1000);
                    Console.WriteLine("У всякого великого деяния есть начало, но лишь пройдя путь до конца, можно обрести истинную славу. Сэр Френсис Дрейк - 1587");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Мы находимся у берегов Панамы, где был предположительно обнаружен гроб Легендарного море плавателя Сэра френсиса Дрейка, похороненного в море больше четырёх веков назад." +
                        "Скажите, а вас не смущает такое надругательство над останками предка?"); // Диалог между Нейтом и Еленой.
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Звучит двусмысленно! Ха-ха-ха..." +
                        "И вы же мне вроде не верили.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Ну, да, я навела кое-какие справки." +
                        "И на сколько мне известно, Френсис Дрейк не оставил потомков");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Ну, историки могут ошибаться. И нельзя..." +
                        "...Надругаться над тем, чего нет");
                    Thread.Sleep(2500);
                    Console.WriteLine("Нейт открыл гроб Френсиса");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Обалдеть...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Вот хитрюга... *Доставая из гроба дневник*");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Что там? Ну-ка, покажите...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Нет-нет, ещё чего. *Закрывая дневник и закрывая рукой камеру Елены*" +
                        "Уговор был только на гроб. И всё.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Одну минуточку!" +
                        "Моя программа оплатила эту экспедицию,без нас вы...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Эй-эй-эй");
                    Console.WriteLine("Вы же получили свой сюжет.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Нет, мистер Дрейк, вы подписали контракт.");
                    Console.WriteLine("И я имею право видеть всё, что вы тут...");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Воу-воу-воу...");
                    Thread.Sleep(2500);
                    Console.WriteLine("Давайте это потом...");
                    Thread.Sleep(2500);
                    Console.WriteLine("Салли! У нас проблемы. Давай скорей.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Так, так, а что там случилось? *Подбигая к Нейту*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Э-э... Пираты.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Пираты!?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Да. Современные. Эти пленных не берут. *Достаёт пистолет*");
                    Console.WriteLine("Ну по крайнеё мере мужчин не берут.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Стоп...вы о чём вообще говорите...");
                    Console.WriteLine("К короблю подплывют пираты.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Может, нам вызвать береговую охрану?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine(" По идее надо бы, но у нас у самих нет разрешения тут находиться.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Чего?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Да, так, что если не хотите в панамскую тюрьму, придётся разбираться с ними самим.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("А что хуже?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Да, вы явно не были в панамской тюрьме." +
                        "Стрелять-то хоть умеете? *Кидая пистолет Елене*");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Ну, это как камера?" +
                        "Просто... наводишь и жмёшь, да?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Всё так и есть." +
                        "Поехали.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("Как они вообще здесь нас нашли?.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Они давно за мной охотятся, я думал отстали");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Елена:");
                    Console.ResetColor();
                    Console.WriteLine("И чем вы их так разозлили?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Натан:");
                    Console.ResetColor();
                    Console.WriteLine("Это долгая история..."); // Конец Диалога, Начало геймплея.
                    Console.ForegroundColor = ConsoleColor.DarkRed; //  Смена цвета.
                    Console.WriteLine("                                           -------1-------");
                    Console.WriteLine("                                               Засада   ");
                    Console.ResetColor();  //  Возвращаем цвет к стандартному.
                    Console.WriteLine("Вы можете Прыгнуть в море (В море), Начать стрелять по пиратам (Стрелять), Спрятаться за коробками (Кемперить)."); // Первый выбор.
                    string fight1 = Console.ReadLine();
                    if ((fight1 == "В море") || (fight1 == "в море") || (fight1 == "В МОРЕ")) // концовки с прыыжком в море.
                    {
                        Console.WriteLine("Вы прыгнули в море");
                        Console.WriteLine("Вы можете: Поплыть к пиратам (Плыть), Стрелять из воды (Стрелять) или Нырнуть (Нырнуть).");
                        string vodichka = Console.ReadLine();
                        switch (vodichka) // Первая концовка при прыгнуть в море, как ни странно, она полностью логична в рамках игры.
                        {
                            case "Плыть":
                            case "плыть":
                                Console.WriteLine("Пока вы пытались подплыть к пиратам, они попали тебе в указательный палец правой руки и ты ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("погиб!"); // Для тех кто не понял, почему он умер от выстрела в палец, в Uncharted есть система "Удачи" и по ней, вы умираете от любого попадания.
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Елена:");
                                Console.ResetColor();
                                Console.WriteLine("Нет, Неееееейт!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                break;
                            case "Стрелять": // Вторая концовка если прыгнуть в море.
                            case "стрелять":
                            case "СТРЕЛЯТЬ":
                                Console.WriteLine("Вы открыли огонь по пиратам из моря.");
                                Console.WriteLine("Не самое дальновидное решение. Вас почти сразу убили.");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                Console.ResetColor();
                                break;
                            case "Нырнуть":
                            case "нырнуть":
                            case "НЫРНУТЬ":
                                Console.WriteLine("Вы нырнули под воду, но увы на вас напали подводники.");
                                Console.WriteLine("Вас убили");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Нет, Нейт!");
                                Console.ResetColor();
                                break;
                        }
                    }
                    else if ((fight1 == "Кемперить") || (fight1 == "кемперить") || (fight1 == "КЕМПЕРИТЬ")) // Концовки для любителей посидеть в кустах.
                    {
                        Console.WriteLine("Вы спрятались за коробками, к нейсчастью для вас они простреливаются, но к счастью для вас, пираты косые."); // Да, они такие же косые как ваши тиммейты в играх
                        Console.WriteLine("ВЫ можете открыть огонь (Стрелять) или ждать (Афк)");
                        string korobki = Console.ReadLine();
                        switch (korobki) // Первая концовка при игре в режиме кемпера. Даже в квест игре можно отлететь за Афк.
                        {
                            case "Афк":
                            case "афк":
                            case "АФК":
                            case "afk":
                            case "Afk":
                            case "AFK":
                                Console.WriteLine("Вы ушли в Афк");
                                Console.WriteLine("A few moments later");
                                Console.WriteLine("Вы получили по башке Банхаммером, за афк.");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Елена:");
                                Console.ResetColor();
                                Console.WriteLine("Боже, Неееееейт!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                Console.ResetColor();
                                break;
                        }
                        if ((korobki == "Стрелять") || (korobki == "стрелять") || (korobki == "СТРЕЛЯТЬ")) // Две концовки, при стрельбе из-за коробок.
                        {
                            Console.WriteLine("Вы открыли огонь по пиратам.");
                            Console.WriteLine("Вы убили двух пиратов, а они попали по Елене.");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Елена:");
                            Console.ResetColor();
                            Console.WriteLine("Чёрт, Нейт, в меня попали!");
                            Console.WriteLine("Елена получила кровотечение, если вы не найдёте аптечку, она погибнет.");
                            Console.WriteLine("Продолжить стрелять по пиратам (Продолжить стрелять) или Пойти в искать на корабле аптечку (Искать аптечку)");
                            string krovotichenieEleni = Console.ReadLine();
                            switch (krovotichenieEleni)
                            {
                                case "Продолжить стрелять": // Первая концовка из Кемперить/Стрелять/
                                case "продолжить стрелять":
                                case "ПРОДОЛЖИТЬ СТРЕЛЯТЬ":
                                    Console.WriteLine("Вы решили не обращать внимания на рану Елены и продолжить стрельбу.");
                                    Console.WriteLine("Елена погибла от кровотечения, вы остались одни.");
                                    Console.WriteLine("Со временем пиратов становилось всё больше и больше, они вас начали окружать и в один момент попали в тебя. Вы погибли.");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                                case "Искать аптечку": // Вторая концовка из Кемперить/Стрелять/
                                case "искать аптечку":
                                case "ИСКАТЬ  АПТЕЧКУ":
                                    Console.WriteLine("Вы решили не игнорировать рану Елены и найти аптечку.");
                                    Console.WriteLine("Вы зашли в каюту.");
                                    Console.WriteLine("Вы нашли аптечку, отдали её Елене. И она заличила свои раны.");
                                    Console.WriteLine("Но пока вы мешкали, пираты пробрались к вам на корабль.");
                                    Console.WriteLine("Ваша реакция была слишком плоха, увы...Вас застрелили.");
                                    Console.WriteLine("Нет, Ней.....");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                            }
                        }
                    }
                    else if ((fight1 == "Стрелять") || (fight1 == "стрелять") || (fight1 == "СТРЕЛЯТЬ-"))
                    {
                        Console.WriteLine("Вы начали стрелять по пиратам.");
                        Console.WriteLine("Вы убили почти всех, но пираты всё прибывали.");
                        Console.WriteLine("Что делать?");
                        Console.WriteLine("Продолжать отстреилваться (Отстреливаться) или спрятаться за коробками (Кемперить), или прыгнуть в море (В море)");
                        string streliat = Console.ReadLine();
                        if ((streliat == "Отстреливаться") || (streliat == "отстреливаться") || (streliat == "ОТСТРЕЛИВАТЬСЯ"))
                        {
                            Console.WriteLine("Вы продолжили отстреливаться от пиратов.");
                            Console.WriteLine("В скором времени прилетел Салли.");
                            Console.WriteLine("Мы залезли к нему в самолёт и улетели!");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("                                            You won");
                            Console.ResetColor();
                        }
                        else if ((streliat == "Кемперить") || (streliat == "кемперить") || (streliat == "КЕМПЕРИТЬ"))
                        {
                            Console.WriteLine("Вы спрятались за коробками, к нейсчастью для вас они простреливаются, но к счастью для вас, пираты косые.");
                            Console.WriteLine("ВЫ можете открыть огонь (Стрелять) или ждать (Афк)");
                            string vodichka = Console.ReadLine();
                            switch (vodichka)
                            {
                                case "Афк":
                                case "афк":
                                case "АФК":
                                case "afk":
                                case "Afk":
                                case "AFK":
                                    Console.WriteLine("Вы ушли в Афк");
                                    Console.WriteLine("A few moments later");
                                    Console.WriteLine("Вы получили по башке Банхаммером, за афк.");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Елена:");
                                    Console.ResetColor();
                                    Console.WriteLine("Боже, Неееееейт!");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        else if ((streliat == "В море") || (streliat == "в море") || (streliat == "В МОРЕ"))
                        {
                            Console.WriteLine("Вы прыгнули в море");
                            Console.WriteLine("Вы можете: Поплыть к пиратам (Плыть), Стрелять из воды (Стрелять) или Нырнуть (Нырнуть).");
                            string vodichka2 = Console.ReadLine();
                            switch (vodichka2)
                            {
                                case "Плыть":
                                case "плыть":
                                case "ПЛЫТЬ":
                                    Console.WriteLine("Пока вы пытались подплыть к пиратам, они попали тебе в указательный палец правой руки и ты погиб!"); // Для тех кто не понял, почему он умер от выстрела в палец, в Uncharted есть система "Удачи" и по ней, вы умираете от любого попадания.
                                    Console.WriteLine("Елена: Нет, Неееееейт!");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    break;
                                case "Стрелять":
                                case "стрелять":
                                case "СТРЕЛЯТЬ":
                                    Console.WriteLine("Вы открыли огонь по пиратам из моря.");
                                    Console.WriteLine("Не самое дальновидное решение. Вас почти сразу убили.");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                                case "Нырнуть":
                                case "нырнуть":
                                case "НЫРНУТЬ":
                                    Console.WriteLine("Вы нырнули под воду, но увы на вас напали подводники.");
                                    Console.WriteLine("Вас убили");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Елена:");
                                    Console.ResetColor();
                                    Console.WriteLine("Нет, Нейт!");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                            }

                        }
                    }
                }
                else if ((start == "Нет") || (start == "нет") || (start == "No") || (start == "no") || (start == "NO") || (start == "НЕТ")) // Альтернативная концовка.
                {
                    Console.WriteLine("Ну тогда уходи!");
                    Console.WriteLine("Вы можете отказаться (Я не уйду)");
                    string LoL = Console.ReadLine();
                    if ((LoL == "Я не уйду") || (LoL == "я не уйду"))
                    {
                        Console.WriteLine("Ушёл БЫСТРО!");
                        Console.WriteLine("Ударить? (Ударить)");
                        string hit = Console.ReadLine();
                        switch (hit)
                        {
                            case "Ударить":
                            case "ударить":
                                Console.WriteLine("Вы нанесли удар");
                                Console.WriteLine("Ай! Полиция, меня бьют!");
                                Console.WriteLine("Поздравляю, Вас посадили!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Извини, что?");
                }
            }
            else if (speak == "English")
            {
                                Console.WriteLine("Welcome to Uncharted: Drake's Fortune, the truth in the form of a quest game.");
                Console.WriteLine("Well, let's get started?");
                string start = Console.ReadLine();
                if ((start == "Да") || (start == "да") || (start == "Yes") || (start == "yes") || (start == "YES") || (start == "ДА"))
                {
                    Console.WriteLine("Great! we are starting!");
                    Thread.Sleep(1000);
                    Console.WriteLine("And so, Nate's story begins");
                    Thread.Sleep(1000);
                    Console.WriteLine("Every great deed has a beginning, but only by following the path to the end can one gain true glory. Sir Francis Drake - 1587");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("We are off the coast of Panama, where the coffin of the legendary navigator Sir Francis Drake, buried at sea more than four centuries ago, was supposedly discovered." +
                                      "Tell me, do you not mind such abuse of the remains of an ancestor?"); // Диалог между Нейтом и Еленой.
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("It sounds ambiguous! Ha-ha-ha..." +
                                       " And you didn't seem to believe me.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("Well, yes, I made some inquiries. " +
                                      " And as far as I know, Francis Drake left no descendants");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("Well, historians can be wrong. And you can't... " +
                                      "...To abuse what is not there");
                    Thread.Sleep(2500);
                    Console.WriteLine("Nate opened Francis' coffin");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("Wow...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("That sly one... * Taking the diary out of the coffin*");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("What's there? Come on, show me...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("No, no, what else. * Closing the diary and closing Elena's camera with her hand * " +
                                      " The agreement was only for the coffin. And everything.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("One minute!" +
                                      " My program paid for this expedition, without us you...");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("Hey-hey-hey");
                    Console.WriteLine("You got your story.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("No, Mr. Drake, you signed the contract.");
                    Console.WriteLine("And I have the right to see everything that you are here...");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("Whoa, whoa, whoa...");
                    Thread.Sleep(2500);
                    Console.WriteLine("Let's do it later...");
                    Thread.Sleep(2500);
                    Console.WriteLine("Sally! We have a problem. Come on, hurry up.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("Well, well, what happened there? * Running up to Nate*");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("Uh... Pirates.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("Pirates!?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("Yes. Modern. These don't take prisoners. * Pulls out a gun*");
                    Console.WriteLine("Well, at least they don't take men.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("Stop...what are you talking about anyway...");
                    Console.WriteLine("Pirates are sailing up to the ship.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("Should we call the Coast Guard?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine(" In theory, it would be necessary, but we ourselves do not have permission to be here.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("What?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("Yes, so if you don't want to go to a Panamanian prison, you'll have to deal with them yourself.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("And what's worse?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("Yes, you obviously haven't been in a Panamanian prison." +
                                      "Do you even know how to shoot? * Throwing a gun to Elena*");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("Well, is it like a camera?" +
                                      " is simple... pointing and pressing, right?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("That's the way it is." +
                                      "Let's go.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("How did they find us here at all?.");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("They have been hunting me for a long time, I thought they had fallen behind");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Elena:");
                    Console.ResetColor();
                    Console.WriteLine("And why did you make them so angry?");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Nathan:");
                    Console.ResetColor();
                    Console.WriteLine("It's a long story..."); // Конец Диалога, Начало геймплея.
                    Console.ForegroundColor = ConsoleColor.DarkRed; //  Смена цвета.
                    Console.WriteLine("                                           -------1-------");
                    Console.WriteLine("                                               Ambush   ");
                    Console.ResetColor();  //  Возвращаем цвет к стандартному.
                    Console.WriteLine("You can jump into the sea (Into the sea), Start shooting at pirates (Shoot), Hide behind boxes (Camper)."); // Первый выбор.
                    string fight1 = Console.ReadLine();
                    if ((fight1 == "Into the sea") || (fight1 == "into the sea") || (fight1 == "INTO THE SEA")) // концовки с прыыжком в море.
                    {
                        Console.WriteLine("Jumped into the sea");
                        Console.WriteLine("You can: Swim to the pirates (Swim), Shoot out of the water (Shoot) or Dive (Dive).");
                        string vodichka = Console.ReadLine();
                        switch (vodichka) // Первая концовка при прыгнуть в море, как ни странно, она полностью логична в рамках игры.
                        {
                            case "Swim":
                            case "swim":
                                Console.WriteLine("While you were trying to swim up to the pirates, they hit you in the index finger of your right hand and you");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("died!"); // Для тех кто не понял, почему он умер от выстрела в палец, в Uncharted есть система "Удачи" и по ней, вы умираете от любого попадания.
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Elena:");
                                Console.ResetColor();
                                Console.WriteLine("No, Noooooo!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                break;
                            case "Shoot": // Вторая концовка если прыгнуть в море.
                            case "shoot":
                            case "SHOOT":
                                Console.WriteLine("You opened fire on pirates from the sea.");
                                Console.WriteLine("Not the most far-sighted decision. You were killed almost immediately.");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                Console.ResetColor();
                                break;
                            case "dive":
                            case "Dive":
                            case "DIVE":
                                Console.WriteLine("You dived under the water, but alas, you were attacked by submariners.");
                                Console.WriteLine("You were killed");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Elena:");
                                Console.ResetColor();
                                Console.WriteLine("No, Nate!");
                                Console.ResetColor();
                                break;
                        }
                    }
                    else if ((fight1 == "Camper") || (fight1 == "camper") || (fight1 == "CAMPER")) // Концовки для любителей посидеть в кустах.
                    {
                        Console.WriteLine("You hid behind the boxes, unfortunately for you they shoot through, but fortunately for you, the pirates are oblique."); // Да, они такие же косые как ваши тиммейты в играх
                        Console.WriteLine("You can open fire (Shoot) or wait (Afk)");
                        string korobki = Console.ReadLine();
                        switch (korobki) // Первая концовка при игре в режиме кемпера. Даже в квест игре можно отлететь за Афк.
                        {
                            case "Afk":
                            case "afk":
                            case "AFK":
                                Console.WriteLine("You left for Afk");
                                Console.WriteLine("A few moments later");
                                Console.WriteLine("You got hit in the head by a Banhammer, for afk.");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Elena:");
                                Console.ResetColor();
                                Console.WriteLine("God, Noooooo!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                Console.ResetColor();
                                break;
                        }
                        if ((korobki == "Shoot") || (korobki == "shoot") || (korobki == "SHOOT")) // Две концовки, при стрельбе из-за коробок.
                        {
                            Console.WriteLine("You opened fire on the pirates.");
                            Console.WriteLine("You killed two pirates, and they hit Elena.");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Elena:");
                            Console.ResetColor();
                            Console.WriteLine("Damn, Nate, I've been hit!");
                            Console.WriteLine("Elena got bleeding, if you don't find a first aid kit, she will die.");
                            Console.WriteLine("Continue shooting at the pirates (Continue shooting) or Go to look for a first aid kit on the ship (Look for a first aid kit)");
                            string krovotichenieEleni = Console.ReadLine();
                            switch (krovotichenieEleni)
                            {
                                case "Continue shooting": // Первая концовка из Кемперить/Стрелять/
                                case "continue shooting":
                                case "CONTINUE SHOOTING":
                                    Console.WriteLine("You decided to ignore Elena's wound and continue shooting.");
                                    Console.WriteLine("Elena died of bleeding, you were left alone.");
                                    Console.WriteLine("Over time, the pirates became more and more, they began to surround you and at one point got into you. You're dead.");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                                case "Look for a first aid kit": // Вторая концовка из Кемперить/Стрелять/
                                case "look for a first aid kit":
                                case "LOOK FOR A FIRST AID KIT":
                                    Console.WriteLine("You decided not to ignore Elena's wound and find a first aid kit.");
                                    Console.WriteLine("You went into the cabin.");
                                    Console.WriteLine("You found a first aid kit, gave it to Elena. And she healed her wounds.");
                                    Console.WriteLine("But while you were procrastinating, the pirates made their way to your ship.");
                                    Console.WriteLine("Your reaction was too bad, alas...You were shot.");
                                    Console.WriteLine("No, Nay.....");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                            }
                        }
                    }
                    else if ((fight1 == "Shoot") || (fight1 == "shoot") || (fight1 == "SHOOT"))
                    {
                        Console.WriteLine("You started shooting at the pirates.");
                        Console.WriteLine("You killed almost everyone, but the pirates kept coming.");
                        Console.WriteLine("What to do?");
                        Console.WriteLine("Continue to shoot back (Shoot back) or hide behind boxes (Camper), or jump into the sea (Into the sea)");
                        string streliat = Console.ReadLine();
                        if ((streliat == "Shoot back") || (streliat == "shoot back") || (streliat == "SHOOT BACK"))
                        {
                            Console.WriteLine("You continued to shoot back at the pirates.");
                            Console.WriteLine("Soon Sally arrived.");
                            Console.WriteLine("You got on his plane and flew away!");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("                                            You won");
                            Console.ResetColor();
                        }
                        else if ((fight1 == "Camper") || (fight1 == "camper") || (fight1 == "CAMPER")) // Концовки для любителей посидеть в кустах.
                        {
                            Console.WriteLine("You hid behind the boxes, unfortunately for you they shoot through, but fortunately for you, the pirates are oblique."); // Да, они такие же косые как ваши тиммейты в играх
                            Console.WriteLine("You can open fire (Shoot) or wait (Afk)");
                            string korobki = Console.ReadLine();
                            switch (korobki) // Первая концовка при игре в режиме кемпера. Даже в квест игре можно отлететь за Афк.
                            {
                                case "Afk":
                                case "afk":
                                case "AFK":
                                    Console.WriteLine("You left for Afk");
                                    Console.WriteLine("A few moments later");
                                    Console.WriteLine("You got hit in the head by a Banhammer, for afk.");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Elena:");
                                    Console.ResetColor();
                                    Console.WriteLine("God, Noooooo!");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        if ((fight1 == "Into the sea") || (fight1 == "into the sea") || (fight1 == "INTO THE SEA")) // концовки с прыыжком в море.
                        {
                            Console.WriteLine("Jumped into the sea");
                            Console.WriteLine("You can: Swim to the pirates (Swim), Shoot out of the water (Shoot) or Dive (Dive).");
                            string vodichka = Console.ReadLine();
                            switch (vodichka) // Первая концовка при прыгнуть в море, как ни странно, она полностью логична в рамках игры.
                            {
                                case "Swim":
                                case "swim":
                                    Console.WriteLine("While you were trying to swim up to the pirates, they hit you in the index finger of your right hand and you");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("died!"); // Для тех кто не понял, почему он умер от выстрела в палец, в Uncharted есть система "Удачи" и по ней, вы умираете от любого попадания.
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Elena:");
                                    Console.ResetColor();
                                    Console.WriteLine("No, Noooooo!");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    break;
                                case "Shoot": // Вторая концовка если прыгнуть в море.
                                case "shoot":
                                case "SHOOT":
                                    Console.WriteLine("You opened fire on pirates from the sea.");
                                    Console.WriteLine("Not the most far-sighted decision. You were killed almost immediately.");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("                                              GAME OVER");
                                    Console.ResetColor();
                                    break;
                                case "dive":
                                case "Dive":
                                case "DIVE":
                                    Console.WriteLine("You dived under the water, but alas, you were attacked by submariners.");
                                    Console.WriteLine("You were killed");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Elena:");
                                    Console.ResetColor();
                                    Console.WriteLine("No, Nate!");
                                    Console.ResetColor();
                                    break;
                            }

                        }
                    }
                }
                else if ((start == "Нет") || (start == "нет") || (start == "No") || (start == "no") || (start == "NO") || (start == "НЕТ")) // Альтернативная концовка.
                {
                    Console.WriteLine("Well, then go away!");
                    Console.WriteLine("You can refuse (I won't leave)");
                    string LoL = Console.ReadLine();
                    if ((LoL == "I'm not leaving") || (LoL == "i'm not leaving"))
                    {
                        Console.WriteLine("Left QUICKLY!");
                        Console.WriteLine("Hit him? (Hit)");
                        string hit = Console.ReadLine();
                        switch (hit)
                        {
                            case "Hit":
                            case "hit":
                                Console.WriteLine("You struck a blow");
                                Console.WriteLine("Ah! Police, I'm being beaten!");
                                Console.WriteLine("Congratulations, you have been imprisoned!");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("                                              GAME OVER");
                                Console.ResetColor();
                                Console.ReadKey();
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("I'm sorry, what?");
                }
            }
            Console.ReadKey();
        }
    }
}