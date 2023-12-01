
class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying.");
    }

    public virtual void Read()
    {
        Console.WriteLine("Pupil is reading.");
    }

    public virtual void Write()
    {
        Console.WriteLine("Pupil is writing.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Pupil is relaxing.");
    }
}

class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Excellent pupil is studying excellently");
    }

    public override void Read()
    {
        Console.WriteLine("Excellent pupil is reading excellently");
    }

    public override void Write()
    {
        Console.WriteLine("Excellent pupil is writing excellently");
    }

    public override void Relax()
    {
        Console.WriteLine("Excellent pupil is relaxing");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Good pupil is studying good");
    }

    public override void Read()
    {
        Console.WriteLine("Good pupil is reading good");
    }

    public override void Write()
    {
        Console.WriteLine("Good pupil is writing good");
    }

    public override void Relax()
    {
        Console.WriteLine("Good pupil is relaxing");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Bad pupil is studying badly");
    }

    public override void Read()
    {
        Console.WriteLine("Bad pupil is reading badly");
    }

    public override void Write()
    {
        Console.WriteLine("Bad pupil is writing badly");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad pupil is relaxing badly");
    }
}

class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        if (pupils.Length != 4)
        {
            throw new ArgumentException("A ClassRoom must have 4 pupils.");
        }

        this.pupils = pupils;
    }

    public void Teach()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new ExcellentPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.Teach();
    }
}
