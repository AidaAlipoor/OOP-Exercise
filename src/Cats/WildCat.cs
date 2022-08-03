namespace Cats
{
    internal class WildCat : Parent, IWalk
    {
        public override string CatColor { get; protected set; } = "Black";
        public override string CatFood { get; protected set; } = "Rabbit";
        public string Walk() => $"{CatColor} cat is walking";
    }

}
