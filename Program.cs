using System;

class Program
{
    static void Main()
    {
        // --- Настройки Gladiators ---
        Console.WriteLine("====== СОЗДАНИЕ ГЕРОЯ №1 ======");
        Console.Write("Запас здоровья: ");
        int healthP1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Показатель брони (%): ");
        int armorP1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n====== СОЗДАНИЕ ГЕРОЯ №2 ======");
        Console.Write("Запас здоровья: ");
        int healthP2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Показатель брони (%): ");
        int armorP2 = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int totalAttacks = 0; // Счетчик совершенных атак

        Console.WriteLine("\n--- ПОЕДИНОК НАЧАЛСЯ ---");

        // Цикл продолжается, пока живы оба участника
        while (healthP1 > 0 && healthP2 > 0)
        {
            // --- Атакует Игрок 1 ---
            int rawDamage1 = random.Next(15, 41);
            int NetDamage1 = rawDamage1 * (100 - armorP2) / 100; // Расчет чистого урона с учетом брони
            healthP2 -= NetDamage1;
            totalAttacks++;

            Console.WriteLine($"Гладиатор 1 наносит {rawDamage1} ед. урона (чистыми: {NetDamage1}). Здоровье Гладиатора 2: {healthP2}");

            if (healthP2 <= 0)
                break; // Второй боец повержен, выходим из цикла

            // --- Атакует Игрок 2 ---
            int rawDamage2 = random.Next(15, 41);
            int NetDamage2 = rawDamage2 * (100 - armorP1) / 100;
            healthP1 -= NetDamage2;
            totalAttacks++;

            Console.WriteLine($"Гладиатор 2 наносит {rawDamage2} ед. урона (чистыми: {NetDamage2}). Здоровье Гладиатора 1: {healthP1}");
        }

        // --- Подведение итогов арены ---
        Console.WriteLine("\n--- ПОЕДИНОК ОКОНЧЕН ---");
        Console.WriteLine($"Всего произведено выстрелов/ударов: {totalAttacks}");

        if (healthP1 > 0 && healthP2 <= 0)
        {
            Console.WriteLine("Триумфатором становится Гладиатор 1!");
        }
        else if (healthP2 > 0 && healthP1 <= 0)
        {
            Console.WriteLine("Триумфатором становится Гладиатор 2!");
        }
        else
        {
            Console.WriteLine("Взаимное уничтожение. На арене не осталось выживших.");
        }

        Console.ReadLine(); // Ожидание нажатия Enter перед закрытием
    }
}
