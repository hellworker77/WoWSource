using System.Linq;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;
using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;

namespace Host.ImplementationEquipCommands;

public class ChestplateEquipCommand : AbstractEquipCommand
{
    public ChestplateEquipCommand(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }
    protected override string CommandString => "Chestplate";
    protected override void InternalLogic()
    {
        var item = _viewModel.SelectedPlayer.Bag?.SelectedItem;
        if (item.Type == ItemType.None)
        {
            return;
        }

        var itemInBag = _viewModel.SelectedPlayer.Bag.Items.FirstOrDefault(i => i.Name == item.Name);


        var savedItem = _viewModel.SelectedPlayer.Inventory.Chestplate;
        _viewModel.SelectedPlayer.Inventory.Chestplate = new ItemDto();
        _viewModel.SelectedPlayer.Inventory.Chestplate.SetSourceValue(item);
        _viewModel.SelectedPlayer.Update();
        itemInBag.SetSourceValue(savedItem);


        base.InternalLogic();
    }
}