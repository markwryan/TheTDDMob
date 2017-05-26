using NUnit.Framework;
using TheTDDMob;

namespace TheTDDMobTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PassedInPointAndRectangleReturnsTrue()
        {
            // Arrange
            var point = new Point(0, 0);
            var rectangle = new Rectangle(0, 0, 1, 1);
            
            // Act
            var result = Task1.IsInRectangle(point, rectangle);
            
            // Assert
            Assert.IsTrue(result);
        }
        
        
        [Test]
        public void PointThatIsOutsideRectangleReturnsFalse()
        {
            // Arrange
            var point = new Point(-1, 1);
            var rectangle = new Rectangle(0, 0, 5, 5);
            
            // Act
            var result = Task1.IsInRectangle(point, rectangle);
            
            // Assert
            Assert.IsFalse(result);
        }
        
        [Test]
        public void PointThatHasAnXCoordinateTooBigReturnsFalse()
        {
            // Arrange
            var point = new Point(10, 1);
            var rectangle = new Rectangle(0, 0, 5, 5);
            
            // Act
            var result = Task1.IsInRectangle(point, rectangle);
            
            // Assert
            Assert.IsFalse(result);
        }
        
        
        [Test]
        public void PointThatIsInsideRectangleReturnsTrue()
        {
            // Arrange
            var point = new Point(1, 1);
            var rectangle = new Rectangle(0, 0, 5, 5);
            
            // Act
            var result = Task1.IsInRectangle(point, rectangle);
            
            // Assert
            Assert.IsTrue(result);
        }
    }
}