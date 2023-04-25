using DecoratorePattern;
EasyEnemy easyEnemy = new EasyEnemy();
HelmetDecorator enemyWithHelmet = new HelmetDecorator(easyEnemy);
ArmourDecorator enemyWithArmourAndHelmet = new ArmourDecorator(enemyWithHelmet);
double computedDamage = enemyWithArmourAndHelmet.TakeDamage();

Console.WriteLine("Damage one punch "+computedDamage);
