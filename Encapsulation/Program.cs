﻿using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation
            //Encapsulation - начина да си скрием имплементацията. Дава възможност за гъвкавост на кода, намалява сложността на кода, промените остават локални и ни позволяа да правим валидации. Идеята е да скрием сложната имплементация на нещо и да направим кода по-четим и по-лесен за поддръжка. Идеята е да скрием ненужна за външния свят информация, това не е сайбър секюрити (не е за да не ни хакнат)! Енкапсулация няма нищо общо със секюрити! 
            //Това с колата и енджина е пример за добра енкапсулация, защото портебителя има старт и стоп и не се интересува от сложността на енджина и тя не му се показва!!! Не е нужно да показваме на външния свят методи и пропъртита, които не го интересуват и само ще му усложнят живота! Така ако има нужда да променим нещо го правим локално в класа и не се налага да променяме на много места! 
            //Правим публични само необходими неща!
            //List<T> е добър пример за добра енкапсулация, дава ни само нужното за да работим с него и не ни занимава с това как работи (например вътрешния масив)!!!
            //Енкапсулацията ни помага да направим нашия клас лесен за използване от юзера (юзер френдли), чрез нея му подаваме само това което му трябва (него не го интересува как работи отвътре и не е нужно да го занимаваме с това)!
            //!!!За да избегна безкрайна рекурсия и получа енкапсулация чрез недопускане да ми сетнат отвън невалидни ст-сти, в конструктора си сетвам пропъртитата (така ще мина през валидацията в прайвет сетера), а в пропъртитата сетвам СЛЕД ВАЛИДАЦИЯ стойност (value) на прайвет полетата (feelds)!!! Така имам добре защитен клас!
            //!!!Validation:
            //Валидация можем да направим и в конструктор, но обикновено се прави в пропърти (в сетъра), там и е мястото, a конструктора вика пропъртито, където се сетва сетъра (сетъра е прайвет и сетва на прайвет полето - така се преизползва код, така се прави) !!! Дори в случай да нямаме сетер е по добре да си направим прайвет сет и там да сложим валидацията, вместо в конструктора.
            //Информация в нашия клас получаваме през конструктора, пропъртитата и през публични полета (ако има такива), като информацията САМО през публично поле не можем да валидираме и затова публични полета НЕ СЕ ИЗПОЛЗВАТ (с тях класа ни става „разграден двор“)!!!
            //Можем да слагаме аксес модифаяри и на гетери и сетъри в пропърти, но само на единия, не може и на двата в едно пропърти! Те взимат модифайъра на пропъртито, но на единия можем да кажем друго.
            //!!!Validation - сетерите са удобни за прости валидации. Когато искаме да сложим валидации се използват прайвет филдове с публик пропъртита! Конструкторите могат да използват прайвет сетери с валидираща логика.







            //Когато направим пропърти без сетер това означава че мога само веднъж да сложа ст-ст на това пропърти, или веднага след него с "=" или в конструктора и повече никой включително и аз не може да го променя, правя го ReadOnly и така го енкапсулирам.
            //Ако е private set аз мога от вътре в моя клас да му сетвам стойности от където поискам!!! 
            //VS-a ни помага като ако нещо не се ползва ни препоръчва да изтрием (например сетер).
            //Когато имаме повече от едно пропърти с еднаква валидация (например за firstName и lastName) качествения код изисква да изнесем валидиращата логика в метод, а в сетерите ще си викаме метода (повишаваме четимостта и преизползваме код)!!!
            //По принцип в приложение се хвърлят Exception – и, а които ни трябват се хващат. Така е прието в правилото за валидации, да се хвърлят Exception - и, а после се прихващат от който трябва. Това ни помага да получаваме само валидни данни (невалидните не ги записваме и хвърляме Exception) и е част от постигането на енкапсулация! 
            //Exception - ите не стигат до крайния потребител, а до този който извиква нашия код и той си ги обработва (прилага Exception handing) или си ги трай кечва или си има генерален начин този ексепшън да не стигне до крайния потребител (в уеб приложение се логват). До крайния потребител може да стига красиво съобщение за грешка (след като някой е обработил нашия ексепшън "и му е придал търговски вид")
            //По принцип трябва да се стараем да правим всичко максимално скрито и нагоре в йерархията (абстрактно)!!!
            // Публично API е списък от публичните методи и пропъртита (много често това са методите и пропъртитата описани в интерфейса), публичния интерфейс на класа или Library -то (методи, пропъртита, които са предназначени за комуникация с външния свят)!!!
            //factory design pattern - споменаха на упражнението да си погледнем!

            //След курса за УЕБ ще можем да вдигаме цялостни уеб приложения, например за около 2 мес. бихме могли да вдигнем едно slido! В момента можем да напишем изцяло конзолно приложение.

            //readonly се слага само на полета и ако го сложим можем да му дадем ст-ст с "=" срещу него или в конструктора, никаде другаде!!! (идеята е като на пропърти само с гет - пак може само конструктора да му задава ст-ст)









            //Пропърти само с гет освен в конструктора може да получи ст-ст и така: public int MyProp {get;} = 2; !!?(не бях виждал)
            //Ако ни се налага да кастваме в повечето случаи означава че имаме лош дизайн - не сме си направили добре класовете, наследяването и обектите. Ако знаем нещо че е от конкретен тип го правим от конкретен тип, не го правим базово да го кастваме после, но ако имаме наследяване и искаме да кастнем към по-базовия клас, тогава нещата са добре!
            //"=>" се използва в съкратения запис на пропъртито или метода вместо return!!!

            //Ники предпочита да си работи с пропърти с прайвет сет вместо с пропърти само с гет и поле (явно е еквивалентно)!!!

            //this ни дава достъп до нещата на настоящата инстанция на обекта.
            //this можем да подаваме като параметри на други методи или параметри в конструкторите на други класове. 
            //this означава - подавам текущата инстанция на обекта!!! 
            //this и текущата/настоящата инстанция на обекта (например var person = new Person()) СОЧАТ КЪМ ЕДНО И СЪЩО МЯСТО В ПАМЕТТА!!!
            //this може да бъде връщан и като стойност, това се използва ако искам да мога да чейнвам методи, например : person.StartSchool(school).ReportAge().StartSchool(school) - но това се използва сравнително рядко! 
            //this. име на локален метод, можем да го извикаме!!!

            //Acssess modifiers - те са основен инструмент да правим енкапсулация
            //Да избягваме private класове и private интерфейси, обикновено са Internal. 

            //private са филдовете, ЗАДЪЛЖИТЕЛНО!!!

            //Пропъртитата дефолтно са internal. 
            //Internal е дефолтния модификатор за класовете и ни дава достъп на всички класове във същия проект (тъй-като това е възможно най-ниския достъп за клас, защото прайвет няма смисъл за клас).










            //Независимо от дефолтните ст-сти качествения код ни ЗАДЪЛЖАВА да пишем Acssess modifiers!!!

            //В ООП правим Class Library -тa на практика и за разлика от конзолните приложения, които вече знаем да пишем, те си нямат СТАРТ защото си нямат мейн метод. Class Library -тa правим за да можем да разделим смислово проекта, обикновено едно Class Library отговаря за една задача! 
            //Class Library -то можем да свържем с конзолно приложение, като дадем от Dependencies на конзолното приложение референция към Library -то (с тикчето) и така вече конзолно приложение се свързва и може да използва Library -то (без референцията неймспейса на Library -то не е достъпен и не мога да го ползвам). По този начин имам достъп до публичния интерфейс на Library -то (методи, пропъртита, които са предназначени за комуникация с външния свят), не с неговите вътрешни (прайвет или интърнъл мембъри) Интърнал мембърите са си САМО за вътрешно ползване в Library -то!!!
            //Когато трябва да запазим чувствителна информация (лични данни), трябва да я криприраме (има криптиращи алгуритми на няколко реда код, които използват публичен ключ за заключване, но ключа за отключване е при вас)(Има и тип данни Secure String от System Secure, който може да свърши работа). Защо правим това, като казваме че е недостъпно (енкапсулирано) за външния свят - защото има програми, които могат да вземат да прочетат и запишат паметта на нашата програма и ако имаме стрингове в нея, те ще могат да бъдат прочетени като текст от паметта на нашата прогама. Ако някой има достъп до компютъра с администраторски права и има такава програма, тя може да чете паметта на другите програми. В базите данни се използва хеширане за тази цел (когато записваме пароли, егенета и др. чувствителна информация, хеширащите функции връщат един дълъг стринг за една парола - винаги еднакъв, който запаметяваме!!! и при сравняване с различен резултат казваме че паролата не отговаря, т.е. ние сравняваме резултатите от хеширащите функции). Пароли в чист вид не се пазят по никакъв повод, пазят се хеширани. Теоритично никой не може от хеширания стринг да възвърне оригиналната парола.  

            //name of (firstName) е по - добре от "firstName" (когато става дума за име на променлива), защото впоследствие ако сменим името на firstName автоматично ще се промени и там!!!










            //В C# circle Dependencies е забранено, ако даващия се окаже че има нужда от нещо от ползвателя, се прави междинен клас с общите между тях неща за да се избегне circle Dependencies. 

            //Когато видим в грешките да ни пише Inconsistent accessibility това означава че опитваме да доступим нещо (клас) с по - макла достъпност (например ние сме интърнал, пък онова е прайвет)

            //private<protected<internal<public - достъпност

            //assembly == project

            //Immutable Objects == unchangeable - create new memory every time they're modified (string, int, Tuple); Всичките им пропъртита са само гетери, и ние можем да си направим такива (само с гетери, или с прайвет сетери и прайвет полета). Това са типове данни, които не можем да променяме след като сме конструирали!!!

            //Ако вътрешна промяна на прайвет поле се случва от някой извикан отвън метод то тогава обекта ни не е Immutable.

            // Mutable Objects == changeable - use the same memory location (StringBuilder, List); 
            //if we have private mutable fields they are still not encapsulated!!! Когато имаме референтни типове данни моя обект не е Immutable. Immutable е ако благодарение на някой от интерфейсите IReadOnlyCollection, IReadOnlyDictionary или IReadOnlyList (те изискват съществуването на този метод и според нуждите можем да използваме един от тях) извикам метода .AsReadOnly() и той прави този тип данни такъв, на който е забранено отвън да му се пипат данните (обикновено правим това в пропъртито, а в прайвет полето ни остава възможността от вътре в каса да правим промени)!!!
            //Правим си прайвет лист на поле, пропъртито един от интерфейсите, но връщаме полето.AsReadOnly() и така затваряме отвън, но от вътре можем да променяме полето. 












            //Пример:
            //    public class Team
            //{
            //    private List<Person> players;
            //    public IReadOnlyCollection<Player> Players
            //    {
            //        get
            //        {
            //            return this.players.AsReadOnly();
            //        }
            //    }
            //}
            // Но с такъв метод public void AddPlayer(Person player) вътре в класа аз ще мога да добавям, защото полето си е нормален лист и след като имам достъп от вътре мога (през пропъртито и аз не мога, а то е достъпно отвън)!!!:

            //когато работим с колекции които сме сложили на прайвет полета, винаги в конструктора е добре да си ги инициализираме за да нямаме "NullReferenceExeption"!!!

            //public void AddPlayer(Person player)
            //   => this.players.Add(player);

            //Енкапсулацията ни помага да се изпълняват поставени от нас изисквания.

            //Oсновен принцип в ООП е че всеки клас трябва да отговаря за едно нещо и да върши само него.

            //Често използвана архитектура в ООП (Engine class)
            //В папка Core се слага бизнес логиката, а в Models класовете, а в Common - GlobalConstants - константи, които се използват в повече от един клас в проекта.












            //Удобен метод: String.IsNullOrEmpty/IsNullOrWhiteSpace(value)

            //Хубаво е да чистим using - и, които не използваме! 

            //IEnumerable ни дава просто енумератор, да имаме foreach, докато IColection вече ни дава индексация, дава ни да добавяме, дава ни почти вдички неща които има списъка (List-a). IEnumerable е по-голямата абстракция и ни дава просто четене и циклене, докато IColection ни дава повече функционалности!!!

            //Web Developer, C# Developer, ASP.Net Develpoper като завършим такива възможности за реализация трябва да гледаме.

            //Така правим увеличение в метод с процент подаден от вън :
            //public void IncreaseSalary(decimal percent)
            //{
            //    this.Salary *= 1 + (percent / 100);
            //Това горе е еквивалентно на това: this.Salary = this.Salary + this.Salary * (percent/100); и на това: this.Salary+= this.Salary * (percent/100);
            //}

            //Полезни клавишни комбинации: Ctrl+ <- kурсора отива наляво в края на думта, така е и на дясно. Ctrl+Shift+<-  маркира по този начин! Shift+Home те праща в началото на реда, Shift+end те праща в края на реда!

            //React vs Angular = 80:20 определено ни препоръчва React

            //fn+q включвал вентилатора на макс

        }
    }
}
