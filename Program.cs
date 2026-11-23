namespace Boss_final;

/*
    CONSIGNES
    Vous développez le système de combat d'un RPG. Le héros affronte un boss final.

    Le boss possède 150 PV. Le héros possède une arme qui inflige 40 dégâts par attaque.

    Vous devez créer trois méthodes :

    1. CalculateWeaponDamage()
        - Reçoit la puissance de l'arme en paramètre.
        - Retourne les dégâts infligés (ici, la puissance de l'arme).
    2. CalculateRemainingHealth()
        - Reçoit les PV actuels du boss et les dégâts infligés.
        - Calcule les nouveaux PV du boss.
        - Retourne les nouveaux PV.
    3. DisplayBossStatus()
        - Reçoit les PV du boss.
        - Affiche son état :
        - Si ses PV sont supérieurs à 0 : "Le boss est toujours vivant !".
        - Sinon : "Félicitations ! Le boss est vaincu !".
    Dans Main() :
        1. Initialisez les PV du boss à 150.
        2. Calculez les dégâts de l'arme.
        3. Infligez les dégâts au boss.
        4. Affichez son état.
        5. Recommencez une deuxième attaque.
        6. Affichez à nouveau son état.
    BONUS :
        - Inspirez-vous de votre combat du cours de Logique & Algorithmes pour aller plus loin dans cet exercice
 */
class Program
{
    static int BossHealth = 150; 
    static int WeaponDamage = 40;
    
    static void Main()
    {
        while (BossHealth > 0)
        {
            CalculateWeaponDamage();
            CalculateRemainingHealth();
            DisplayBossStatus();
        }        
    }
    
    static void CalculateWeaponDamage()
    {
        Console.WriteLine("Le héros inflige " + WeaponDamage + " dégats");
    }
    
    static void CalculateRemainingHealth()
    {
        BossHealth = BossHealth - WeaponDamage;
    }

    static void DisplayBossStatus()
    {
        if (BossHealth > 0)
        {
            Console.WriteLine("Le boss toujours vivant !");
            Console.WriteLine("Le boss a " + BossHealth + " restant !");
        }
        else
        {
            Console.WriteLine("Le boss est vaincu !");
        }
    }
}