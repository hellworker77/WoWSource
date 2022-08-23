using Dai.Entities.Implementation;
using System.Collections.ObjectModel;
using Dai.Entities.Abstractions;

namespace Hellworker.Wow.Core.Domain.Models;

public class BagDto
{
    public ObservableCollection<ItemDto?> Items
    {
        get
        {
            var result = new List<ItemDto?>(_items);

            if (Size > result.Count)
            {
                var empty = Enumerable.Range(0, (Size) - result.Count).Select(x => new ItemDto()).ToList<ItemDto>();
                result.AddRange(empty);
            }

            return new ObservableCollection<ItemDto?>(result);
        }
        set => _items = value;
    }

    public ItemDto? SelectedItem
    {
        get => _selectedItem;
        set => _selectedItem = value;
    }

    public int Size
    {
        get => _size;
        set => _size = value;
    }

    public BagDto()
    {

    }

    private ObservableCollection<ItemDto?> _items = new ObservableCollection<ItemDto?>();
    private ItemDto? _selectedItem;
    private int _size;
}