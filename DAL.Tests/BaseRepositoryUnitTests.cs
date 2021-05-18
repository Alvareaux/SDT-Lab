using Lab.DAL.EF;
using Lab.DAL.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using Record = Lab.DAL.Entities.Record;

namespace DAL.Tests
{
    class TestRecordRepository
        : BaseRepository<Record>
    {
        public TestRecordRepository(DbContext context)
            : base(context)
        {
        }
    }

    public class BaseRepositoryUnitTests
    {

        [Fact]
        public void Create_InputStreetInstance_CalledAddMethodOfDBSetWithStreetInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<TimesheetContext>()
                .Options;
            var mockContext = new Mock<TimesheetContext>(opt);
            var mockDbSet = new Mock<DbSet<Record>>();
            mockContext
                .Setup(context =>
                    context.Set<Record>(
                        ))
                .Returns(mockDbSet.Object);
            //EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            var repository = new TestRecordRepository(mockContext.Object);

            Record expectedStreet = new Mock<Record>().Object;

            //Act
            repository.Create(expectedStreet);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedStreet
                    ), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<TimesheetContext>()
                .Options;
            var mockContext = new Mock<TimesheetContext>(opt);
            var mockDbSet = new Mock<DbSet<Record>>();
            mockContext
                .Setup(context =>
                    context.Set<Record>(
                        ))
                .Returns(mockDbSet.Object);
            //EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            //IStreetRepository repository = uow.Streets;
            var repository = new TestRecordRepository(mockContext.Object);

            Record expectedRecord = new Record() { record_id = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedRecord.record_id)).Returns(expectedRecord);

            //Act
            repository.Delete(expectedRecord.record_id);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedRecord.record_id
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedRecord
                    ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<TimesheetContext>()
                .Options;
            var mockContext = new Mock<TimesheetContext>(opt);
            var mockDbSet = new Mock<DbSet<Record>>();
            mockContext
                .Setup(context =>
                    context.Set<Record>(
                        ))
                .Returns(mockDbSet.Object);

            Record expectedRecord = new Record() { record_id = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedRecord.record_id))
                    .Returns(expectedRecord);
            var repository = new TestRecordRepository(mockContext.Object);

            //Act
            var actualStreet = repository.Get(expectedRecord.record_id);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedRecord.record_id
                    ), Times.Once());
            Assert.Equal(expectedRecord, actualStreet);
        }


    }
}