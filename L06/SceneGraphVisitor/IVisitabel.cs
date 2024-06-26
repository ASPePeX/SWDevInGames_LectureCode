public interface IVisitable
{
    public string Name { get; set; }

    public void Accept(IVisitor visitor);
}