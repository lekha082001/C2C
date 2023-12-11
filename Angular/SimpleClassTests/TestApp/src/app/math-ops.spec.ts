import { MathOps } from './math-ops';

//Creation of a test suite
describe("Math Ops Test Suite",()=>{
  it("Should Add two numbers correctly",()=>{
    //Arrange-Act-Assert
    let num1=100; 
    let num2=200;

    //Act - Call original function
    let result = MathOps.Add(num1,num2)
    //Assert - Jasmine function expect()
    expect(result).toEqual(300);
  })

  it("Should Subtract two numbers correctly",()=>{
    //Arrange-Act-Assert
    let num1=200; 
    let num2=100;

    //Act - Call original function
    let result = MathOps.Subtract(num1,num2)
    //Assert - Jasmine function expect()
    expect(result).toEqual(100);
  })

  it("Should Multiply two numbers correctly",()=>{
    //Arrange-Act-Assert
    let num1=20; 
    let num2=10;

    //Act - Call original function
    let result = MathOps.Multiply(num1,num2)
    //Assert - Jasmine function expect()
    expect(result).toEqual(200);
  })

  it("Should Divide two numbers correctly",()=>{
    //Arrange-Act-Assert
    let num1=200; 
    let num2=100;

    //Act - Call original function
    let result = MathOps.Divide(num1,num2)
    //Assert - Jasmine function expect()
    expect(result).toEqual(2);
  })
})
//Creation of a test case
//Assertion of a test case 