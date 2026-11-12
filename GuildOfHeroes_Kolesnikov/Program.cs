using System.Diagnostics;
//     >>> Герои <<<

Probe.Run();

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

List<Hero> members = guild.GetMembers();

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}


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