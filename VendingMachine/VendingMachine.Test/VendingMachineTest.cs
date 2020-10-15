using System;
using Xunit;
using VendingMachine;
using System.Reflection.PortableExecutable;

namespace VendingMachine
{
    public class VendingMachineTest
    {
        [Theory]
        [InlineData(5)]
        [InlineData(1000)]
        public void ChashOutTest(double userMony)
        {
            //Assagn
            VendingMachine vm = new VendingMachine();


            //Act
            vm.InputMony(userMony);

            //Assurt
            Assert.Equal(userMony, vm.CashOut());
            Assert.Equal(0, vm.CashOut());
           

        }
        [Theory]
        [InlineData(1000)]
        [InlineData(20)]

        public void InputValidMony(double userMony)
        {
            VendingMachine vm = new VendingMachine();

            //Act
            vm.InputMony(userMony);

            //Assurt
            Assert.Equal(userMony, vm.CashOut());

        }
        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        public void NotValidMony(double userMony)
        {
            VendingMachine vm = new VendingMachine();

            //Act          

            //Assert

            Assert.Throws<ArgumentException>(() => vm.InputMony(userMony));
        }



        [Fact]
        public void Choose()
        {
            //Assagn
            int goodButton = 1;
            int badButton = 5;
            VendingMachine vm = new VendingMachine();


            vm.InputMony(1000);

            //Act
            IProduct vm1 = vm.Choose(goodButton);




            //Assert
            Assert.Equal("James", vm1.Brand);
            Assert.Throws<ArgumentException>(() => vm.Choose(badButton));
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]

        public void ShowAllProductsTest(int button)
        {
            VendingMachine vm = new VendingMachine();

            int index = button - 1;
            //Act
            vm.InputMony(1000);
            
            IProduct products = vm.Choose(button);
           
            string[] item = vm.ShowAllProducts();

            //Assert
            Assert.Equal(products.Examine(), item[index]);

        }

        
    }
}
