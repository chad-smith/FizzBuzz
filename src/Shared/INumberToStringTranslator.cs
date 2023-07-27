namespace Shared {
    public interface INumberToStringTranslator {
        bool CheckNumber(int number);
        
        string Value { get; }
    }
}