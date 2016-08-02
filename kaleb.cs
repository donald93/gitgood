namespace Question {

  public class A<T> {
    public class B : A<int> {
      public void M() {
        // Eric Lippert: what does this output?
        System.Console.WriteLine(typeof(T)); }
      public class C : B { }
    }
  }
  public class P {
    public static void Main() {
      (new A<string>.B.C()).M(); 
    }
  }
}
