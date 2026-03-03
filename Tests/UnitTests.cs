namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

	[TestMethod]
	public void Subtract_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Subtract("6", "3"));
	}

	[TestMethod]
	public void Subtract_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
	}

	[TestMethod]
	public void Subtract_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
	}

	[TestMethod]
	public void Multiply_Valid_Patino()
	{
		Assert.AreEqual(9, Program.Multiply("3", "3"));
	}

	[TestMethod]
	public void Multiply_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
	}

	[TestMethod]
	public void Multiply_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
	}

	[TestMethod]
	public void Divide_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Divide("9", "3"));
	}

	[TestMethod]
	public void Divide_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
	}

	[TestMethod]
	public void Divide_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
	}

	[TestMethod]
	public void Power_Valid_Patino() {
		Assert.AreEqual(8, Program.Power("2", "3"));
	}

	[TestMethod]
	public void Power_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "3")); // maybe this will fix it? (it won't)
	}

	[TestMethod]
	public void Power_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
	}
}
