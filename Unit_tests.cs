public static class Unit_tests 
{
    public static void Task1()
    {
        // конструктор
        ComplexNumber c1 = new ComplexNumber(3, 4);
        ComplexNumber c2 = new ComplexNumber(1, 2);
        Console.WriteLine($"c1 = {c1}");
        Console.WriteLine($"c2 = {c2}");

        // сложениe
        ComplexNumber sum = c1 + c2;
        Console.WriteLine($"\n{c1} + {c2} = {sum}");

        // вычитаниe
        ComplexNumber diff = c1 - c2;
        Console.WriteLine($"\n{c1} - {c2} = {diff}");

        // умножениe
        ComplexNumber mult = c1 * c2;
        Console.WriteLine($"\n{c1} * {c2} = {mult}");

        // делениe
        ComplexNumber div = c1 / c2;
        Console.WriteLine($"\n{c1} / {c2} = {div}");

        // Унарный +
        double modulus = +c1;
        Console.WriteLine($"\n|{c1}| = {modulus}");

        // Унарный -
        ComplexNumber conjugate = -c1;
        Console.WriteLine($"\nСопряженное для {c1} = {conjugate}");

        // сравнениe
        ComplexNumber c3 = new ComplexNumber(3, 4);
        Console.WriteLine($"\n{c1} == {c3}? {c1 == c3}");
        Console.WriteLine($"{c1} != {c2}? {c1 != c2}");

        // ToString
        Console.WriteLine($"new ComplexNumber(0, 0) = {new ComplexNumber(0, 0)}");
        Console.WriteLine($"new ComplexNumber(0, 5) = {new ComplexNumber(0, 5)}");
        Console.WriteLine($"new ComplexNumber(3, 0) = {new ComplexNumber(3, 0)}");
        Console.WriteLine($"new ComplexNumber(3, 5) = {new ComplexNumber(3, 5)}");
        Console.WriteLine($"new ComplexNumber(3, -5) = {new ComplexNumber(3, -5)}");
    }

    public static void Task2()
    {
        Console.WriteLine("News service");

        NewsPublisher publisher = new NewsPublisher();

        EmailSubscriber email1 = new EmailSubscriber("yatypoy@gmail.com");
        EmailSubscriber email2 = new EmailSubscriber("bob@yandex.com");
        SmsSubscriber sms = new SmsSubscriber("+7-880-555-35-35");
        PushSubscriber push = new PushSubscriber("Nokia-3310");

        publisher.AddObserver(email1);
        publisher.AddObserver(email2);
        publisher.AddObserver(sms);
        publisher.AddObserver(push);

        publisher.PublishNews("Release Ubuntu 26.04 LTS");

        Console.WriteLine("");
        publisher.RemoveObserver(email2);

        publisher.PublishNews("Opened registration on conferention");
    }

    public static void Task3()
    {
        TreeNode root = new TreeNode("Root");

        TreeNode child1 = new TreeNode("Child 1");
        TreeNode child2 = new TreeNode("Child 2");

        root.AddChild(child1);
        root.AddChild(child2);

        TreeNode grandChild1 = new TreeNode("Grandchild 1.1");
        TreeNode grandChild2 = new TreeNode("Grandchild 1.2");

        child1.AddChild(grandChild1);
        child1.AddChild(grandChild2);

        TreeNode grandChild3 = new TreeNode("Grandchild 2.1");
        child2.AddChild(grandChild3);

        Console.WriteLine("recursive output");
        root.PrintAllValues();
    }
}
