public abstract class Ingredient
{
    public virtual int Id { get; } = 0;
    public virtual string Name { get; } = "Ingredient";
    public virtual string Instruction { get; } = "Instruction";
    public override string ToString() => $"{Id}. {Name}";

    public string PreparationInstruction() => Instruction;
}
