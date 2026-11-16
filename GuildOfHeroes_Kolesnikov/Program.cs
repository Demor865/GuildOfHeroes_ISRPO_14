using System.Diagnostics;
//     >>> Герои <<<

//Probe.Run();

Console.WriteLine("\n    >>> Main <<<\n");

Guild guild = new Guild("Гильдия героев");
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

guild.AddHero(sergey);
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);

Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();

QuestBoard board = new QuestBoard(guild);

Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");
Console.WriteLine();
Console.WriteLine(floatQuest.GetInfo());
Console.WriteLine(sergey.GetInfo());


//     >>> Оружия <<<
Console.WriteLine("\n    >>> Класс оружия <<<\n");

Arsenal arsenal = new Arsenal("Арсенал гильдии героев");

Weapon Sword = new Weapon("Эскалибур", 46, "Меч");
Weapon Bow = new Weapon("Охотничий лук", 5, "Лук");
Weapon Staff = new Weapon("Жезл молний", 34, "Посох");
Weapon LongSword = new Weapon("Дуболом", 26, "Двуручный меч");

arsenal.AddWeapon(Sword);
arsenal.AddWeapon(Bow);
arsenal.AddWeapon(Staff);
arsenal.AddWeapon(LongSword);

List<Weapon> members_Weapon = arsenal.GetMembers_Weapon();

Console.WriteLine($"\n-------------------------");
Console.WriteLine($"ИМЯ - УРОН | ТИП | ПРОЧНОСТЬ");
foreach (Weapon weapon in members_Weapon) {
    Console.WriteLine($"{weapon.Name} - {weapon.Damage} | {weapon.Type} | {weapon.Strength}");
}
Console.WriteLine($"-------------------------\n");

