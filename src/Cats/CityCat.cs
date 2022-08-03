namespace Cats
{
    internal class CityCat : Parent, IWalk
    {
        public override string CatColor { get; protected set; } = "Gray";
        public override string CatFood { get; protected set; } = "Rubbish";
        public string Walk() => $"{CatColor} cat is walking";
    }
}
