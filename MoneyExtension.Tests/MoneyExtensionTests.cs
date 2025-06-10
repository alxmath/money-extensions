namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToint()
    {
        var valor = 279.98M;
        var cents = valor.ToCents();
        
        Assert.AreEqual(27998, cents);
    }
}
