using System;
namespace Tests.Views
{
	public class ItalyTest
	{
		[Fact]
		public void ForEachLoop()
		{
            //Arrange - instantiate the class of the for loop

            var view = new Index();

            //Act 

            var htmlResult = view.RenderAsHtml();

            //Assert

            Assert.Contains("<ul>", htmlResult.ToHtmlString());
            Assert.Contains("<li>Item 1</li>", htmlResult.ToHtmlString());
            Assert.Contains("<li>Item 2</li>", htmlResult.ToHtmlString());
            Assert.Contains("<li>Item 3</li>", htmlResult.ToHtmlString());
        }
    }
}

