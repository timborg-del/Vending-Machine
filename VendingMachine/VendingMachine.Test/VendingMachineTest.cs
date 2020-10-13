using System;
using Xunit;
using VendingMachine;
using System.Reflection.PortableExecutable;

namespace VendingMachine
{
    public class VendingMachineTest
    {
        [Fact]
        public void ChashOutTest()
        {
            //Assagn

            //Act

            //Assurt

        }
        [Fact]
        public void InputMonyTest()
        {
            //Assagn

            //Act

            //Assurt
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
    }
}
