namespace Task4.IndependentWork.Models;

// Реализовал через словарь.
// Реализация с изменением размера массива не имеет значения т.к. по факту в памяти больше ячеек, чем используется.
// Реализовывать словарь с нуля тоже немного дикость
internal sealed class SparseArray<T>(T defaultValue = default(T))
{
    private readonly Dictionary<int, T> _data = new();

    public T this[int index]
    {
        get => _data.GetValueOrDefault(index, defaultValue);
        set
        {
            if (EqualityComparer<T>.Default.Equals(value, defaultValue))
            {
                return;
            }
            _data.TryAdd(index, value);
        }
    }
    
    // Массивы по идее не подразумевают удаление, но задание того просит.
    public bool Remove(int index) => _data.Remove(index);
}